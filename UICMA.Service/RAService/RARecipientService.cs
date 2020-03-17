using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RARecipientRules;
using UICMA.Domain.Entities.RARecipients;
using UICMA.Repository.RARepository;

namespace UICMA.Service.RAService
{
   public class RARecipientService: IRARecipientService
    {
        private IRARecipientRepository _RARecipientRepository;

        public RARecipientService(IRARecipientRepository _RARecipientRepository)
        {
            this._RARecipientRepository = _RARecipientRepository;
        }

        //Get AllRARecipient
        public IEnumerable<RARecipient> GetAllRARecipient()
        {
                return _RARecipientRepository.GetAllRARecipient();
        }
        //Get RARecipient By RARecipientby_Id
         public RARecipient GetRARecipientbyID(int Id)
        {
            return _RARecipientRepository.GetSingle(Id);
        }
        //Get RABatchby By RABatch_Id
        public RARecipient GetRARecipientbyBatchID(int id)
        {
            return _RARecipientRepository.GetRARecipientbyBatchID(id);
        }

        //Delete RARecipient By RARecipientby_Id
        public RARecipient DeleteRARecipientId(int id)
        {
            return _RARecipientRepository.DeleteRARecipientId(id);

        }

        //Get AllRecipient By RABatch_Id
        public List<RARecipientView> GetAllRecipient(int Batchid)
        {
            return _RARecipientRepository.GetAllRecipient(Batchid);

        }
        public List<RARecipientView> GetAllDeliverdRecipient(int Batchid)
        {
            return _RARecipientRepository.GetAllDeliverdRecipient(Batchid);
        }
        public List<RARecipientView> GetAllFailedRecipient(int Batchid)
        {
            return _RARecipientRepository.GetAllFailedRecipient(Batchid);
        }
        
    }
}



