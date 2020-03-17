using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RARecipientRules;
using UICMA.Domain.Entities.RARecipients;

namespace UICMA.Repository.RARepository
{
    public interface IRARecipientRepository : IEntityBaseRepository<RARecipient>
    {
        IEnumerable<RARecipient> GetAllRARecipient();
        RARecipient GetRARecipientbyBatchID(int id);
        RARecipient DeleteRARecipientId(int id);
        List<RARecipientView> GetAllRecipient(int Batchid);
        List<RARecipientView> GetAllDeliverdRecipient(int Batchid);
        List<RARecipientView> GetAllFailedRecipient(int Batchid);
    }
}


