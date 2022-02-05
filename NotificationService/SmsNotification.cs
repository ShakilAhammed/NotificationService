using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    class SmsNotification : INotification
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Message { get; set; }
    }
}
