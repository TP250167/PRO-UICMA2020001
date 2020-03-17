using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RABatchRecipients;
using UICMA.Domain.Entities.RARecipients;

namespace UICMA.Repository.RARepository
{
    public class RARecipientRepository : EntityBaseRepository<RARecipient>, IRARecipientRepository
    {
        private readonly UICMAContext context;
        public RARecipientRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
        public IEnumerable<RARecipient> GetAllRARecipient()
        {
            return context.RARecipient.Where(s => s.Status == "Active").ToList();
        }

        public RARecipient GetRARecipientbyBatchID(int id)
        {
            return context.RARecipient.Where(s => s.Id == id).FirstOrDefault();
        }
        public RARecipient DeleteRARecipientId(int id)
        {
            var Recipient = context.RARecipient.Where(s => s.Id == id).FirstOrDefault();
            Recipient.Status = "InActive";
            context.RARecipient.Update(Recipient);
            context.SaveChanges();
            return (Recipient);
        }
        public List<RARecipientView> GetAllRecipient(int Batchid)
        {
            var Recipient = context.vwTotalRecipient.Where(s => s.Id == Batchid).AsNoTracking().ToList();
            return new List<RARecipientView>(Recipient);          

        }
        public List<RARecipientView> GetAllDeliverdRecipient(int Batchid)
        {
            var Recipients = context.vwTotalRecipient.Where(s => s.Id == Batchid && s.Delivered_On != null).AsNoTracking().ToList();
            return new List<RARecipientView>(Recipients);
        }
        public List<RARecipientView> GetAllFailedRecipient(int Batchid)
        {
            var Recipients = context.vwTotalRecipient.Where(s => s.Id == Batchid && s.Failed_On != null).AsNoTracking().ToList();
            return new List<RARecipientView>(Recipients);
        }
    }
}
