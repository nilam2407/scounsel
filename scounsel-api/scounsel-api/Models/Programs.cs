using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace scounsel_api.Models
{
    public class Programs
    {
       [Key]
       public string program_name { get; set; }
    }

}