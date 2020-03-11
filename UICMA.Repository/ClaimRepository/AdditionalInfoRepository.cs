using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Additional_Information;

namespace UICMA.Repository.ClaimRepository
{   
    public class AdditionalInfoRepository : EntityBaseRepository<AdditionalInformation>, IAdditionalInfoRepository
    {
        private readonly UICMAContext context;
        public AdditionalInfoRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
