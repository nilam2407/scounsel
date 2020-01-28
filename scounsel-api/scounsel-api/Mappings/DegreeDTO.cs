using System;
using System.ComponentModel.DataAnnotations;

namespace scounsel_api.Mappings
{
    public class DegreeDTO
    {
        [Key]
        public string id { get; set; }
        public string program_name { get; set; }
        public string course_id { get; set; }
        public string course_name { get; set; }
    }
}