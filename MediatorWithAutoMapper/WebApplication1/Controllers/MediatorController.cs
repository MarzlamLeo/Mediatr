using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Notification;
using WebApplication1.ReposeDto.ReadReposeDto;
using WebApplication1.RequestDto.ReadRequestDto;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MediatorController : ControllerBase
    {

        private readonly IMediator _mediator;

        public MediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<GetTestResposeDto> TestMediator()
        {
            var result = await _mediator.Send(new GetTestRequestDto
            {
                Id = "1"
            });
            return result;
        }

        [HttpGet]
        public async Task TestMediator2()
        {
            await _mediator.Publish(new TestNotification
            {
                Id = "1"
            });
         
        }

    }
}
