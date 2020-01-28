using System;
using System.ComponentModel.DataAnnotations;

namespace scounsel_api.Mappings
{
    public class ProgramsDTO
    {
        [Key]
        public string program_name { get; set; }
    }
}