using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace scounsel_api.Models
{
    public class Course
    {
        public string course_name { get; set; }
        [Key]
        public string course_id { get; set; }
        public string description { get; set; }
    }

}