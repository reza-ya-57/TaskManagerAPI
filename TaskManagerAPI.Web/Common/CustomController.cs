using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Core.Common;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Interfaces;
using TaskManagerAPI.Infrastructure.Repositories;

namespace TaskManagerAPI.Web.Common
{
    [Route("api/[Controller]")]
    [ApiController]
    public abstract class CustomBaseController<T> : ControllerBase where T : BaseEntity
    {
        protected IBaseRepository<T> _TRepository;
        protected IMapper _mapper;
        private IBaseRepository<User> repository;

        public CustomBaseController(IBaseRepository<T> TRepository , IMapper mapper)
        {
            _TRepository = TRepository;
            _mapper = mapper;
        }

        protected CustomBaseController(IBaseRepository<User> repository)
        {
            this.repository = repository;
        }
    }
}
