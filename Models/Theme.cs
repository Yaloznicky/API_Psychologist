using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopPsychologist_WF.Models
{
    public class Theme
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? PathImage { get; set; }
        public string? ThemeName { get; set; }
        public string? Text { get; set; }
    }
}
