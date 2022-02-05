using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    class EmailNotification : INotification
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public FileStream AttachedFile { get; set; }
    }
}
