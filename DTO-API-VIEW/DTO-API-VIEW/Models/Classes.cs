using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DTO_API_VIEW.Models
{
    public class Classes
    {
        [Key]
        public int ClassId { get; set; }
        [Required(ErrorMessage = "Kademe boş geçilemez!")]
        [DisplayName("Kademe")]
        public int ClassNo { get; set; }
        [Required(ErrorMessage = "Şube boş geçilemez!")]
        [DisplayName("Şube")]
        public string ClassBranch { get; set; }
        public List<Student> Students { get; set; }

        public Classes()
        {
            Students = new List<Studet>();
        }
    }
}
