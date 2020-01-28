using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using scounsel_api.Models;

namespace scounsel_api.Features.degree.Queries.GetAllDegrees
{
    public class GetAllDegreesQuery : IRequest<Degree>
    {
        private readonly ApplicationDbContext _context;

        public GetAllDegreesQuery(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Degree> Handle(GetAllDegreesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
