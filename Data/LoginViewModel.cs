﻿using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Data
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username / Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
