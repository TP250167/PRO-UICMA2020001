using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Writs;

namespace UICMA.Service.ClaimServices
{
   public interface IWritService
    {
        Writ AddandUpdateWrit(Writ writ);
        IEnumerable<Writ> GetWritAll();
        Writ GetWritbyID(int Id);

    }
}
