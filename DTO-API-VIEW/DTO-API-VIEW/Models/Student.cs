using System.ComponentModel.DataAnnotations;

namespace DTO_API_VIEW.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "İsim boş bırakılamaz!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim boş bırakılamaz!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Yaş boş bırakılamaz!")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Adres boş bırakılamaz!")]
        public string Adress { get; set; }
        public int ClassId { get; set; }
        public Classes StudentClasses { get; set; }
    }
}
