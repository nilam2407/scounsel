using System;
using System.ComponentModel.DataAnnotations;

namespace scounsel_api.Mappings
{
    public class CourseDTO
    {
        public string course_name { get; set; }
        [Key]
        public string course_id { get; set; }
        public string description { get; set; }
    }
}
