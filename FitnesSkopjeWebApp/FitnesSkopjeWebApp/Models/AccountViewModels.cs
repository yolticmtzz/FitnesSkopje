﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnesSkopjeWebApp.Models
{

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Е-маил")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Лозинка")]
        public string Password { get; set; }

        [Display(Name = "Зачувај ме?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Полето е задолжително!")]
        [Display(Name ="Име")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Полето е задолжително!")]
        [Display(Name = "Презиме")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Полето е задолжително!")]
        [Display(Name = "Адреса")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Полето е задолжително!")]
        [Display(Name = "Телефонски број")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Полето е задолжително!")]
        [EmailAddress]
        [Display(Name = "Е-маил")]
        public string Email { get; set; }
        

        [Required(ErrorMessage = "Полето е задолжително!")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Лозинка")]
        public string Password { get; set; }       


        [DataType(DataType.Password)]
        [Display(Name = "Повтори лозинка")]
        [Compare("Password", ErrorMessage = "Лозинките не се совпаѓаат!")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
