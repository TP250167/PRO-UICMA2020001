using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RARecipients;

namespace UICMA.Service.RAService
{
   public interface IRARecipientService
    {
        IEnumerable<RARecipient> GetAllRARecipient();
        RARecipient GetRARecipientbyID(int id);
        RARecipient GetRARecipientbyBatchID(int id);
        RARecipient DeleteRARecipientId(int id);
        List<RARecipientView> GetAllRecipient(int Batchid);
        List<RARecipientView> GetAllDeliverdRecipient(int Batchid);
        List<RARecipientView> GetAllFailedRecipient(int Batchid);
    }
}
