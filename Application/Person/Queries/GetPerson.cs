using MediatR;
using Persistence;

namespace Application.Person.Queries
{
    public class GetPerson
    {
        public class GetPersonQuery : IRequest<Domain.Entities.Person>
        {
            public int Id { get; set; }
        }

        public class GetPersonHandler : IRequestHandler<GetPersonQuery, Domain.Entities.Person>
        {
            public DataContext _context { get; set; }
            public GetPersonHandler(DataContext context)
            {
                _context = context;
            }

            public async Task<Domain.Entities.Person> Handle(GetPersonQuery request, CancellationToken cancellationToken)
            {
                return await _context.Person.FindAsync(request.Id);
            }
        }
    }
}