using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using scounsel_api.Models;

namespace scounsel_api.Features.courses.Queries.GetAllCourses
{
    public class GetAllCoursesQuery : IRequest<Course>
    {
        private readonly ApplicationDbContext _context;

        public GetAllCoursesQuery(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Course> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
