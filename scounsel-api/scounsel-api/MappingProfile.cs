using System;
using AutoMapper;
using scounsel_api.Mappings;
using scounsel_api.Models;

namespace scounsel_api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CourseDTO>();
            CreateMap<Degree, DegreeDTO>();
            CreateMap<Programs, ProgramsDTO>();
        }
    }
}
