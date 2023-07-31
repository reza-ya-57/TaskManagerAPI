using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Interfaces;
using TaskManagerAPI.Web.Common;

namespace TaskManagerAPI.Web.Controllers.BaseControllers
{
    public class UserController : CustomBaseController<User>
    {
        public UserController(IBaseRepository<User> TRepository, IMapper mapper) : base(TRepository, mapper)
        {
        }
        [Authorize]
        [HttpGet("GetUsers")]
        public async Task<IEnumerable<User>> GetAllUser()
        {
            List<User>  response = await _TRepository.GetAllAsync();
            return response;
        }

        [HttpGet("GetUser")]
        public async Task<User> GetUserByIdAsync(long userId)
        {
            User response = await _TRepository.GetByIdAsync(userId);
            return response;
        }
    }
}
