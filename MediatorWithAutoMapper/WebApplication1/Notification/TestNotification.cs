using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Notification
{
    //声明一个 Test的团购
    public class TestNotification: INotification
    {
        public string Id { get; set; }
    }
}
