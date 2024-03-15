using MediatR;
using Persistence;

namespace Application.Person.Queries
{
    public class GetPeople
    {
        public class GetPeopleQuery : IRequest<List<Domain.Entities.Person>>
        {
        }

        public class GetPersonHandler : IRequestHandler<GetPeopleQuery, List<Domain.Entities.Person>>
        {
            public DataContext _context { get; set; }
            public GetPersonHandler(DataContext context)
            {
                _context = context;
            }

            public Task<List<Domain.Entities.Person>> Handle(GetPeopleQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}