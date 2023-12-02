﻿using EnglishVibes.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace EnglishVibes.API.DTO
{
    public class GroupDto
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string StudyPlan { get; set; } 
        public bool ActiveStatus { get; set; }
        public List<Instructor>? Instructors { get; set; } = new List<Instructor>();

        public List<string>? Students { get; set; } = new List<string>();

       
    }
}
