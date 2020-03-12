using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RARecipients;

namespace UICMA.Service.RAService
{
   public interface IRARecipientService
    {
        IEnumerable<RARecipient> GetAllRARecipient();
        RARecipient GetRARecipientbyID(int id);
        RARecipient GetRARecipientbyBatchID(int id);
        RARecipient DeleteRARecipientId(int id);

    }
}
