using MVCPictureCRUD.CustomValidations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCPictureCRUD.Models
{
    public class Animal
    {
        [Required]
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Type")]
        [Required]
        public AnimalType Type { get; set; }
        [Required]
        [DisplayName("Name")]
        [StringLength(50, ErrorMessage = "Name can not be longer than 50 characters!")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters!")]
        public string Name { get; set; }

        [DisplayName("Birth")]
        [BirthDateValidation(ErrorMessage = "Date cannot be greater than now and lower than 50 years ago!")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Image")]
        public string? PicturePath { get; set; }
        [DisplayName("Sound")]
        public string? SoundPath { get; set; }
        public Animal(int ıd, AnimalType type, string name, DateTime birthDate, string? picturePath, string? soundPath)
        {
            Id = ıd;
            Type = type;
            Name = name;
            BirthDate = birthDate;
            PicturePath = picturePath;
            SoundPath = soundPath;
        }
        public Animal()
        {

        }
    }
    public enum AnimalType
    {
        [Display(Name = "Cat")]
        Cat,
        [Display(Name = "Dog")]
        Dog,
        [Display(Name = "Mouse")]
        Mouse,
        [Display(Name = "Bird")]
        Bird,
        [Display(Name = "Fish")]
        Fish,
        [Display(Name = "Other")]
        Other,
    }
}
