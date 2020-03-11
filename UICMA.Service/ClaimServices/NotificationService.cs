using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Notifications;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
  public  class NotificationService: INotificationService
    {
        private INotificationRepository _notification;

        public NotificationService(INotificationRepository _notification)
        {
            this._notification = _notification;

        }


        //Add and Update Notification

        public Notification AddandUpdateNotification(Notification notification)
        {
            Notification notifications = new Notification();


            if (notification.Id == 0)
            {
                notifications = _notification.AddData(notification);
            }
            else
            {
                notifications = _notification.UpdateData(notification);
            }
              return notifications;

        }

        //Get Notification All


        public IEnumerable<Notification> GetNotificationAll()
        {

            return _notification.GetAll();

        }
        //Get Notification By Notification_Id

        public Notification GetNotificationbyID(int Id)
        {

            return _notification.GetSingle(Id);

        }
    }
}
