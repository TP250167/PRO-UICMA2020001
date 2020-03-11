using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Notifications;

namespace UICMA.Service.ClaimServices
{
   public interface INotificationService
    {
        Notification AddandUpdateNotification(Notification notification);
        IEnumerable<Notification> GetNotificationAll();
        Notification GetNotificationbyID(int Id);

    }
}
