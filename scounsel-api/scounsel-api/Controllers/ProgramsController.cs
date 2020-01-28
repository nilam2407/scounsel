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
    public class ProgramsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProgramsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //GET: api/programs
       [HttpGet]
        public List<ProgramsDTO> Get()
        {
            string query = "Select * from programs";

            List<ProgramsDTO> programList = new List<ProgramsDTO>();
            var result = _context.Programs.FromSql(query).ToList();
            foreach (var item in result)
            {
                programList.Add(_mapper.Map<ProgramsDTO>(item));
            }

            return programList;
        }

    }
}
