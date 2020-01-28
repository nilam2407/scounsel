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
    public class DegreesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DegreesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //GET: api/degrees
       [HttpGet]
        public List<DegreeDTO> Get()
        {
            string query = "Select * from degree";

            List<DegreeDTO> degreeList = new List<DegreeDTO>();
            var result = _context.Degrees.FromSql(query).ToList();
            foreach (var item in result)
            {
                degreeList.Add(_mapper.Map<DegreeDTO>(item));
            }

            return degreeList;
        }

    }
}
