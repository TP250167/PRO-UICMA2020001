using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Request_To_Reopen;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class RequestToReopenService: IRequestToReopenService
    {
        private IRequestToReopenRepository _RequestToReopen;

        public RequestToReopenService(IRequestToReopenRepository _RequestToReopen)
        {
            this._RequestToReopen = _RequestToReopen;

        }


        //Add and Update requestToReopen

        public RequestToReopen AddandUpdateRequestToReopen(RequestToReopen requestToReopen)
        {
            RequestToReopen Appeal = new RequestToReopen();


            if (requestToReopen.Id == 0)
            {
                Appeal = _RequestToReopen.AddData(requestToReopen);
            }
            else
            {
                Appeal = _RequestToReopen.UpdateData(requestToReopen);
            }




            return Appeal;

        }

        //Get requestToReopen All


        public IEnumerable<RequestToReopen> GetRequestToReopenAll()
        {

            return _RequestToReopen.GetAll();

        }
        //Get requestToReopen By RequestToReopen_Id

        public RequestToReopen GetRequestToReopenbyID(int Id)
        {

            return _RequestToReopen.GetSingle(Id);

        }





    }
}
