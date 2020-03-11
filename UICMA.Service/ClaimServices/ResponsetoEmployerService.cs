using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Response_to_Employer;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class ResponsetoEmployerService: IResponsetoEmployerService
    {
        private IResponsetoEmployerRepository _responsetoEmployer;

        public ResponsetoEmployerService(IResponsetoEmployerRepository _responsetoEmployer)
        {
            this._responsetoEmployer = _responsetoEmployer;

        }


        //Add and Update ResponseToEmployer

        public ResponseToEmployer AddandUpdateResponseToEmployer(ResponseToEmployer responsetoEmployer)
        {
            ResponseToEmployer responsetoEmp = new ResponseToEmployer();


            if (responsetoEmployer.Id == 0)
            {
                responsetoEmp = _responsetoEmployer.AddData(responsetoEmployer);
            }
            else
            {
                responsetoEmp = _responsetoEmployer.UpdateData(responsetoEmployer);
            }




            return responsetoEmp;

        }

        //Get ResponseToEmployer All


        public IEnumerable<ResponseToEmployer> GetResponseToEmployerAll()
        {

            return _responsetoEmployer.GetAll();

        }
        //Get ResponseToEmployer By ResponseToEmployer_Id

        public ResponseToEmployer GetResponseToEmployerbyID(int Id)
        {

            return _responsetoEmployer.GetSingle(Id);

        }
    }
}
