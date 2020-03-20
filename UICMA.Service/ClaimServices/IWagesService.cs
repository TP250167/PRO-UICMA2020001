using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.NoticeOfWages;

namespace UICMA.Service.ClaimServices
{
  public interface IWagesService
    {

        Wages AddandUpdateWages(Wages wages);
        IEnumerable<Wages> GetWagesAll();
        Wages GetWagesbyID(int Id);
    }
}
