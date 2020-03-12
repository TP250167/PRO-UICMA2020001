using UICMA.Domain.Entities.RABatchRecipients;

namespace UICMA.Repository.RARepository
{
    public class RABatchRecipientRepository : EntityBaseRepository<RABatchRecipient>, IRABatchRecipientRepository
    {
        private readonly UICMAContext context;
        public RABatchRecipientRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}