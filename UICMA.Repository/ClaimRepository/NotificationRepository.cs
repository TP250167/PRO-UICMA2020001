using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Notifications;

namespace UICMA.Repository.ClaimRepository
{
   

    public class NotificationRepository : EntityBaseRepository<Notification>, INotificationRepository
    {
        private readonly UICMAContext context;
        public NotificationRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
