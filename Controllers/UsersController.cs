using API_Psychologist.Models;
using DesktopPsychologist_WF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace API_Psychologist.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController(ApplicationContext context) : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            List<User> users = context.Users.ToList();
            return Ok(users);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            User? user = await context.Users.FirstOrDefaultAsync(user => user.Id == id);
            if (user != null) 
            {
                return user;
            }
            else
            {
                return NotFound(new { message = "Пользователь не найден." });
            }
        }

        // GET api/<UsersController>/by-login?login=userLogin
        [HttpGet("by-login")]
        public async Task<ActionResult<User>> GetUserByLogin([FromQuery] string login)
        {
            User? user = await context.Users.FirstOrDefaultAsync(user => user.Login == login);
            if (user != null)
            {
                return user;
            }
            else
            {
                return NotFound(new { message = "Пользователь не найден." });
            }
        }

        // POST api/<UsersController>
        [HttpPost]
        //public void Post([FromBody] User user)
        public IActionResult Post(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return Ok("добавлено");
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, User user)
        {
            User userInDB = context.Users.FirstOrDefault(user => user.Id == id)!;
            if (userInDB != null)
            {
                userInDB.Login = user.Login;
                userInDB.Gender = user.Gender;
                userInDB.Password = user.Password;
                context.SaveChanges();
            }
            return Ok("изменено");
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            context.Users.Remove(context.Users.FirstOrDefault(user => user.Id == id)!);
            context.SaveChanges();
            return Ok("удалено");
        }
    }
}
