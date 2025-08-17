using API_Psychologist.Models;
using DesktopPsychologist_WF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Psychologist.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ThemesController(ApplicationContext context) : ControllerBase
    {
        // GET: api/<ThemesController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Theme> themes = context.Themes.ToList();
            return Ok(themes);
        }

        // GET api/<ThemesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Theme>> GetTheme(int id)
        {
            Theme? theme= await context.Themes.FirstOrDefaultAsync(theme => theme.Id == id);
            if (theme != null)
            {
                return theme;
            }
            else
            {
                return NotFound(new { message = "Запрос несуществующей услуги." });
            }
        }

        // POST api/<ThemesController>
        [HttpPost]
        public IActionResult Post(Theme theme)
        {
            context.Themes.Add(theme);
            context.SaveChanges();
            return Ok("добавлено");
        
        }

        // PUT api/<ThemesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Theme theme)
        {
            Theme themeInDB = context.Themes.FirstOrDefault(theme => theme.Id == id)!;
            if (themeInDB != null)
            {
                themeInDB.ThemeName = theme.ThemeName;
                themeInDB.Text = theme.Text;
                context.SaveChanges();
            }
            return Ok("изменено");
        }

        // DELETE api/<ThemesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            context.Themes.Remove(context.Themes.FirstOrDefault(theme => theme.Id == id)!);
            context.SaveChanges();
            return Ok("удалено");
        }
    }
}
