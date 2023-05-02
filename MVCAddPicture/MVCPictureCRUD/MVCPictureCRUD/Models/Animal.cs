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

        [DisplayName("Genus")]
        [Required(ErrorMessage = "Please select an animal type.")]
        public AnimalType Type { get; set; }

        [Required(ErrorMessage = "Please enter the name of the animal.")]
        [DisplayName("Name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters!")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters!")]
        public string Name { get; set; }


        //[DisplayFormat(DataFormatString = "{dd.MM.yyyy}")]
        [DisplayName("Birth")]
        [BirthDateValidation(ErrorMessage = "The date cannot be further than now or more than 50 years.")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Image")]
        public string? PicturePath { get; set; }

        [DisplayName("Sound")]
        public string? SoundPath { get; set; }

        public Animal(int id, AnimalType type, string name, DateTime birthDate, string? picturePath, string? soundPath)
        {
            Id = id;
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
