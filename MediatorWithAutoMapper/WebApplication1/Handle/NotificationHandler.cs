using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApplication1.Notification;
using WebApplication1.ReposeDto.ReadReposeDto;

namespace WebApplication1.Handle
{
    public class NotificationHandler: INotificationHandler<TestNotification>
    {
        public Task Handle(TestNotification notification, CancellationToken cancellationToken)
        {
            //处理业务 
            var a= "aaa";
            return Task.CompletedTask;
            
        }

    }
}
