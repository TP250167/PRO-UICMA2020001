using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.RARecipientRules;

namespace UICMA.Service.RAService
{
    public interface IRABatchService
    {

        RABatchView CreateBatch(RABatchView Batch);
        IEnumerable<RABatchView> GetAllRABatch();
        RABatchView GetRABatchbyID(int Id);
        RABatchViewModel GetBatchViewbyID(int Batchid);
        List<RANotificationViewModel> GetRANotificationList(int Batchid);
        IEnumerable<RABatchView> GetAllRABiWeeklyBatch();
    }
}
