using DesktopPsychologist_WF.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Psychologist.Models
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
    {
        public DbSet<Theme> Themes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
