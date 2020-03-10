using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Response_to_Employer;

namespace UICMA.Repository.ClaimRepository
{
    
    public class ResponsetoEmployerRepository : EntityBaseRepository<ResponseToEmployer>, IResponsetoEmployerRepository
    {
        private readonly UICMAContext context;
        public ResponsetoEmployerRepository(UICMAContext context) : base(context)
        {
            this.context = context;
        }
    }
}
