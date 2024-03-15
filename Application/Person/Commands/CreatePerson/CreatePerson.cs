using MediatR;
using Persistence;

namespace Application.Person.Commands.CreatePerson
{
    public class CreatePerson
    {
        public class CreatePersonCommand : IRequest
        {
            public Domain.Entities.Person Person { get; set; }
        }

        public class CreatePersonHandler : IRequestHandler<CreatePersonCommand>
        {
            public DataContext _context { get; set; }
            public CreatePersonHandler(DataContext context)
            {
                _context = context;
            }

            public async Task Handle(CreatePersonCommand request, CancellationToken cancellationToken)
            {
                _context.Person.Add(request.Person);
                await _context.SaveChangesAsync();
            }
        }
    }
}