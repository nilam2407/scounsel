using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using scounsel_api.Features.courses.Queries.GetAllCourses;
using scounsel_api.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using scounsel_api.Mappings;

namespace scounsel_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CoursesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //GET: api/courses
       [HttpGet]
        public List<CourseDTO> Get()
        {
            string query = "Select * from courses";

            List<CourseDTO> courseList = new List<CourseDTO>();
            var result = _context.Courses.FromSql(query).ToList();
            foreach (var item in result)
            {
                courseList.Add(_mapper.Map<CourseDTO>(item));
            }

            return courseList;
        }

    }
}
