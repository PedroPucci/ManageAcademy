using Application.Person.Queries;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PersonController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPeople()
        {
            return await Mediator.Send(new GetPeople.GetPeopleQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            return await Mediator.Send(new GetPerson.GetPersonQuery() { Id = id });
        }
    }
}