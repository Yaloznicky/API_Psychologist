using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopPsychologist_WF.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DateTimeReview { get; set; }
        public string? Text { get; set; }
        public int UsersId { get; set; }
        public virtual User? Users { get; set; } = null;
    }
}
