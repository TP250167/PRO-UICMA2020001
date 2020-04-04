using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.MD_Form;

namespace UICMA.Service.MasterData
{
   public interface IMDFormService
    {
        MDForm AddandUpdateMDForm(MDForm form);
        IEnumerable<MDForm> GetMDFormAll();
        MDForm GetMDFormbyID(int Id);

    }
}
