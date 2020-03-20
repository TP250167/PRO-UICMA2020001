using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Request_For_EmployeeData;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class RequestForEmpDataService: IRequestForEmpDataService
    {
        private IRequestForEmpDataRepository _RequestForEmp;

        public RequestForEmpDataService(IRequestForEmpDataRepository _RequestForEmp)
        {
            this._RequestForEmp = _RequestForEmp;

        }


        //Add and Update RequestForEmployeeData

        public RequestForEmployeeData AddandUpdateRequestForEmpData(RequestForEmployeeData request)
        {
            RequestForEmployeeData Appeal = new RequestForEmployeeData();


            if (request.Id == 0)
            {
                Appeal = _RequestForEmp.AddData(request);
            }
            else
            {
                Appeal = _RequestForEmp.UpdateData(request);
            }

              return Appeal;

        }

        //Get RequestForEmployeeData All


        public IEnumerable<RequestForEmployeeData> GetRequestForEmpDataAll()
        {

            return _RequestForEmp.GetAll();

        }
        //Get RequestForEmployeeData By RequestForEmployeeData_Id

        public RequestForEmployeeData GetRequestForEmpDatabyID(int Id)
        {

            return _RequestForEmp.GetSingle(Id);

        }

    }
}
