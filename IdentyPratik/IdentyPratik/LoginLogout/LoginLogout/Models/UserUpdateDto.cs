﻿using System.ComponentModel.DataAnnotations;

namespace LoginLogout.Models
{

    public class UserUpdateDto
    {

        public string Id { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adını boş geçmeyiniz...")]
        [StringLength(15, ErrorMessage = "Lütfen kullanıcı adını 4 ile 15 karakter arasında giriniz...", MinimumLength = 4)]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen emaili boş geçmeyiniz...")]
        [EmailAddress(ErrorMessage = "Lütfen email formatında bir değer belirtiniz...")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi boş geçmeyiniz...")]
        //[DataType(DataType.Password, ErrorMessage = "Lütfen şifreyi tüm kuralları göz önüne alarak giriniz...")]
        [Display(Name = "Şifre")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Şifre 3 hane!")]
        public string Password { get; set; }
    }
}
