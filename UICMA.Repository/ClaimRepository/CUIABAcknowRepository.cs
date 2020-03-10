using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.CUIAB_Acknowledgement;

namespace UICMA.Repository.ClaimRepository
{
   

    public class CUIABAcknowRepository : EntityBaseRepository<CUIABAcknowledgement>, ICUIABAcknowRepository
    {
        private readonly UICMAContext context;
        public CUIABAcknowRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
