using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Web.Dtos.BaseDto;
using TaskManagerAPI.Web.Exceptions;

namespace TaskManagerAPI.Web.Controllers.BaseControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonController() { }

        [HttpGet("GetPersonstest")]
        public async Task<ActionResult<string>> GetPersons()
        {
            List<PersonRequest> persons = new List<PersonRequest>();

            return "hello";
        }

        [HttpPost("CreatePerson")]
        public async Task<IActionResult> CreatePerson([FromForm] PersonRequest personRequest)
        {
            if (personRequest == null)
            {
                throw new BadRequestException();
            }

            var file = personRequest.File;
            using var openfile = file.OpenReadStream();


            return Ok();
        }
    }
}
