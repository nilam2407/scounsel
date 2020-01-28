using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using scounsel_api.Models;

namespace scounsel_api.Features.program.Queries.GetAllPrograms
{
    public class GetAllProgramsQuery : IRequest<Programs>
    {
        private readonly ApplicationDbContext _context;

        public GetAllProgramsQuery(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Programs> Handle(GetAllProgramsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
