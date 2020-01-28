using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace scounsel_api.Models
{
    public class Degree
    {
       [Key]
       public string id { get; set; }
       public string program_name { get; set; }
       public string course_id { get; set; }
       public string course_name { get; set; }
    }

}