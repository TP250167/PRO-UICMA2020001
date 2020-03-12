using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return context.RARecipient.Where(s => s.Id == id ).FirstOrDefault();
        }
        public RARecipient DeleteRARecipientId(int id)
        {
            var Recipient = context.RARecipient.Where(s => s.Id == id).FirstOrDefault();
            Recipient.Status = "InActive";
            context.RARecipient.Update(Recipient);
            context.SaveChanges();
            return (Recipient);
        }

    }
}

