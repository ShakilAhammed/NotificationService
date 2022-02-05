using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    interface INotificationService
    {
        void SendNotification(INotification notification);
    }
}
