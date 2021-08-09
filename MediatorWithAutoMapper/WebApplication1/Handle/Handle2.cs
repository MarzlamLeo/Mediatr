using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApplication1.Notification;

namespace WebApplication1.Handle
{
    public class Handle2:INotificationHandler<TestNotification>
    {
        public Task Handle(TestNotification notification, CancellationToken cancellationToken)
        {
            //处理业务 
            var a = "aaa";
            return Task.CompletedTask;

        }

    }
}
