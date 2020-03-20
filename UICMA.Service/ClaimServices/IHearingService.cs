using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Hearings;

namespace UICMA.Service.ClaimServices
{
   public interface IHearingService
    {
        Hearing AddandUpdateHearing(Hearing hearing);
        IEnumerable<Hearing> GetHearingAll();
        Hearing GetHearingbyID(int Id);
    }
}
