using Onur_Hoca_MVC.CustomValidations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Onur_Hoca_MVC.Models
{
    [Table("tbl_Customer")]
    public class Customer
    {
        [Required(ErrorMessage = "Id can not be null!")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Company Name can not be null!")]
        [Display(Name = "Company Name")]
        [StringLength(50, ErrorMessage = "Company Name should be less than or equal to 50 characters!")]
        public string CompanyName { get; set; }


        [Required(ErrorMessage = "Email adress can not be null!")]
        [EmailAddress(ErrorMessage = "Wrong format!")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JoinDate { get; set; }

        [JoinDateValidation]
        [EnumDataType(typeof(CustomerType), ErrorMessage = "Customer type is not valid")]
        public CustomerType CustomerType { get; set; }

        [AgeValidation]
        public int Age { get; set; }

        public Customer(int ıd, string companyName, int age, string email, DateTime joinDate, CustomerType customerType)
        {
            Id = ıd;
            CompanyName = companyName;
            Age = age;
            Email = email;
            JoinDate = joinDate;
            CustomerType = customerType;
        }
        public Customer()
        {

        }
    }
}
