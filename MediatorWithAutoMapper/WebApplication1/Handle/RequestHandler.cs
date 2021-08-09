using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using WebApplication1.ReposeDto.ReadReposeDto;
using WebApplication1.RequestDto.ReadRequestDto;

namespace WebApplication1.Handle
{
    //MediatR 请求处理类  声明处理的对应关系
    public class RequestHandler : IRequestHandler<GetTestRequestDto, GetTestResposeDto>
    {
        //Handle 规则实现 处理业务返回
        public Task<GetTestResposeDto> Handle(GetTestRequestDto request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetTestResposeDto { Name = "张三", Age = 18 });
        }
    }
}
