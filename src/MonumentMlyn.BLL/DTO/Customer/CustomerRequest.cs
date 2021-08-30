﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MonumentMlyn.BLL.DTO
{
    public class CustomerRequest
    {
        public CustomerRequest()
        {
            
        }

        public CustomerRequest(string lastName, string surname, string phone, string email)
        {
            LastName = lastName;
            Surname = surname;
            Phone = phone;
            Email = email;
        }

        [StringLength(150, MinimumLength = 3)]
        [Required(ErrorMessage = "Некоректно введені данні")]
        public string LastName { get; set; }

        [StringLength(150, MinimumLength = 3)]
        [Required(ErrorMessage = "Некоректно введені данні")]
        public string Surname { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"((\+38)?\(?\d{3}\)?[\s\.-]?(\d{7}|\d{3}[\s\.-]\d{2}[\s\.-]\d{2}|\d{3}-\d{4}))",
            ErrorMessage = "Not a valid phone number")]
        [Required] public string Phone { get; set; }

        [Required] public string Email { get; set; }
    }
}