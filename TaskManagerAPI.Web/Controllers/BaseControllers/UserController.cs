using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Interfaces;

namespace TaskManagerAPI.Web.Controllers.BaseControllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController :   ControllerBase
    {
        private IBaseRepository<User> _userRepository;  
        public UserController(IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("GetUsers")]
        public async Task<IEnumerable<User>> GetAllUser()
        {
            List<User>  response = await _userRepository.GetAllAsync();
            return response;
        }
    }
}
