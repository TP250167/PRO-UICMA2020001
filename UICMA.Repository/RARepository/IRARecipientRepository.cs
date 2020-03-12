using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RARecipientRules;
using UICMA.Domain.Entities.RARecipients;

namespace UICMA.Repository.RARepository
{
    public interface IRARecipientRepository : IEntityBaseRepository<RARecipient>
    {
        IEnumerable<RARecipient> GetAllRARecipient();
        RARecipient GetRARecipientbyBatchID(int id);
        RARecipient DeleteRARecipientId(int id);

       

    }
}


