﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishVibes.Service.DTO
{
    public class RegisterStudentDTO
    {

        [Range(16, 80)]
        public int? Age { get; set; }

        [MinLength(3)]
        [MaxLength(20)]
        public string? UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [RegularExpression("^(private|group)$")]
        public string StudyPlan { get; set; }
    }
}
