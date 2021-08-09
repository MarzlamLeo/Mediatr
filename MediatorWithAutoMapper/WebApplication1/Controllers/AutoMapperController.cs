using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApplication1.ReposeDto.ReadReposeDto;
using WebApplication1.Entity;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AutoMapperController : ControllerBase
    {
        public readonly IMapper _mapper;
        public AutoMapperController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public List<GetTestResposeDto> AutoTestList()
        {
            var resource = new List<TestEntity>();
            resource.Add(new TestEntity
            {
                Name = "1992-02-02",
                Age = 18
            });
            var res = _mapper.Map<List<TestEntity>,List<GetTestResposeDto>>(resource);
            return res;
        
        }
    }
}
