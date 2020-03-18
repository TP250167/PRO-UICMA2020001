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
            return context.RABatch.Where(s => s.Status == "Active" && s.Frequency == "Yearly").OrderByDescending(s => s.CreatedOn).ToList();
        }
        public RABatchViewModel GetBatchViewbyID(int Batchid)
        {
            return context.spRaBatchDetail.FromSql("spRaBatchDetail  @p0", Batchid).AsNoTracking().FirstOrDefault();        
        }

        public List<RANotificationViewModel> GetRANotificationList(int Batchid)
        {
            var result= context.spRaNotificationList.FromSql("spRaNotificationList  @p0", Batchid).AsNoTracking().ToList();
            return new List<RANotificationViewModel>(result);
        }

        public IEnumerable<RABatchView> GetAllRABiWeeklyBatch()
        {
            return context.RABatch.Where(s => s.Status == "Active" && s.Frequency == "Weekly").OrderByDescending(s => s.CreatedOn).ToList().Take(5);
        }
        public IEnumerable<RABatchView> GetAllRABothBatch()
        {
            return context.RABatch.Where(s => s.Status == "Active").OrderByDescending(s => s.CreatedOn).ToList();
        }


    }
}

