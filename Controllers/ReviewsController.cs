using API_Psychologist.Models;
using DesktopPsychologist_WF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Psychologist.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReviewsController(ApplicationContext context) : Controller
    {
        // GET: api/<ReviewsController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Review> reviews = context.Reviews.Include(r => r.Users).ToList();
            return Ok(reviews);
        }

        // GET api/<ReviewsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReview(int id)
        {
            Review? review = await context.Reviews
                .Include(review => review.Users)
                .FirstOrDefaultAsync(review => review.Id == id);
            if (review != null)
            {
                return review;
            }
            else
            {
                return NotFound(new { message = "Запрос несуществующих данных." });
            }
        }

        // POST api/<ReviewsController>
        [HttpPost]
        public IActionResult Post([FromBody] Review review)
        {
            context.Reviews.Add(review);
            context.SaveChanges();
            return Ok("добавлено");

        }

        // PUT api/<ReviewsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Review review)
        {
            Review reviewInDB = context.Reviews.FirstOrDefault(review => review.Id == id)!;
            if (reviewInDB != null)
            {
                reviewInDB.Text = review.Text;
                context.SaveChanges();
            }
            return Ok("изменено");
        }

        // DELETE api/<ReviewsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            context.Reviews.Remove(context.Reviews.FirstOrDefault(review => review.Id == id)!);
            context.SaveChanges();
            return Ok("удалено");
        }
    }
}
