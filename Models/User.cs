using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;

namespace DesktopPsychologist_WF.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string login,
                    string gender,
                    string password)
        {
            Login = login;
            Gender = gender;
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            Password = hasher.HashPassword(this, password);
            if (Gender == "М") AvatarImage = "img/avatar_M.jpg";
            else AvatarImage = "img/avatar_W.jpg";
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Gender { get; set; }
        public string? Password { get; set; }
        public string? AvatarImage { get; set; }

        [JsonIgnore]
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
