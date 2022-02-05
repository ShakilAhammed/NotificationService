using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public class NotificationService : INotificationService
    {
        public void SendNotification(INotification notification)
        {
            if(notification is EmailNotification)
            {
                //integrate email functionality
                Console.WriteLine($"Email has been sent to {notification.Receiver} successfully.");
            }
            else if(notification is SmsNotification)
            {
                //integrate sms functionality
                Console.WriteLine($"Sms has been sent to {notification.Receiver} successfully.");
            }
            else if (notification is PushNotification)
            {
                //integrate push notification functionality
                Console.WriteLine($"Push notification has been sent to {(notification as PushNotification).AppUserId} successfully.");
            }
            else
            {

            }
        }
    }
}
