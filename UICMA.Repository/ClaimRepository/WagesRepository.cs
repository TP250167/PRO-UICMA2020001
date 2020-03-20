using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.NoticeOfWages;

namespace UICMA.Repository.ClaimRepository
{
    public class WagesRepository : EntityBaseRepository<Wages>, IWagesRepository
    {
        private readonly UICMAContext context;
        public WagesRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
