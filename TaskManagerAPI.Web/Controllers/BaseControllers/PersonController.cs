using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Interfaces;
using TaskManagerAPI.Web.Common;
using TaskManagerAPI.Web.Dtos.BaseDto;
using TaskManagerAPI.Web.Exceptions;

namespace TaskManagerAPI.Web.Controllers.BaseControllers
{
    public class PersonController : CustomBaseController<Person>
    {
        public PersonController(IBaseRepository<Person> TRepository, IMapper mapper) : base(TRepository, mapper)
        {
        }

        [HttpGet("GetAllPerson")]
        public async Task<ActionResult<List<Person>>> GetAllPersonAsync()
        {
            List<Person> persons = await _TRepository.GetAllAsync();
            return persons;
        }


        [HttpPost("GetPersonById")]
        public async Task<ActionResult<Person>> GetPersonByIdAsync(long personId)
        {
            Person person = await _TRepository.GetByIdAsync(personId);
            return person;
        }



        [HttpPost("CreatePerson")]
        public async Task<IActionResult> CreatePerson(PersonRequest personRequest)
        {
            if (personRequest == null)
            {
                throw new BadRequestException();
            }

            Person person = _mapper.Map<Person>(personRequest);


            return Ok();
        }
    }
}
