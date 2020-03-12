using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RABatchs;

namespace UICMA.Repository.RARepository
{
    public class RABatchRepository : EntityBaseRepository<RABatchView>, IRABatchRepository
    {
        private readonly UICMAContext context;
        public RABatchRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }

     
        public IEnumerable<RABatchView> GetAllRABatch()
        {          
            return context.RABatch.Where(s => s.Status == "Active").ToList();
        }
        public RABatchViewModel GetBatchViewbyID(int Batchid)
        {
            return context.spRaBatchDetail.FromSql("spRaBatchDetail  @p0", Batchid).FirstOrDefault();        
        }

        public List<RANotificationViewModel> GetRANotificationList(int Batchid)
        {
            return context.vwRaNotificationList.Where(s => s.Status == "Active").ToList();
        }

    }
}

