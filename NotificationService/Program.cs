using System;

namespace NotificationService
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationService notificationService = new NotificationService();
            notificationService.SendNotification(new SmsNotification() { Receiver = "019xxxxxxx98"});
            notificationService.SendNotification(new EmailNotification() { Receiver = "hello@test.com"});
            notificationService.SendNotification(new PushNotification() { AppUserId = "dummy user"});
        }
    }
}
