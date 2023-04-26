using System.ComponentModel.DataAnnotations;

namespace AliTopluMVC.Models
{
    public class Kisi
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
