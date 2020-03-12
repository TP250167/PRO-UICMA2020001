using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RABatchs;

namespace UICMA.Repository.RARepository
{
    public interface IRABatchRepository : IEntityBaseRepository<RABatchView>
    {
        IEnumerable<RABatchView> GetAllRABatch();
        RABatchViewModel GetBatchViewbyID(int Batchid);
        List<RANotificationViewModel> GetRANotificationList(int Batchid);
    }
}
