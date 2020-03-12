using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities;
using UICMA.Domain.Entities.Employees;
using UICMA.Domain.Entities.Notifications;
using UICMA.Domain.Entities.RA.RAView;
using UICMA.Domain.Entities.RABatchRecipientMap;
using UICMA.Domain.Entities.RABatchRecipientRules;
using UICMA.Domain.Entities.RABatchRecipients;
using UICMA.Domain.Entities.RABatchs;
using UICMA.Domain.Entities.RABatchSchedules;
using UICMA.Domain.Entities.RARecipients;
using UICMA.Domain.Entities.RASchedules;
using UICMA.Domain.Entities.Templates;
using UICMA.Repository.ClaimRepository;
using UICMA.Repository.RARepository;

namespace UICMA.Service.RAService
{
    public class RABatchService : IRABatchService
    {
        private IRABatchRepository _RABatchRepository;

        private IRAScheduleRepository _RAScheduleRepository;
        private IRABatchScheduleRepository _RABatchScheduleRepository;
        private IEmployeeInfoDataRepository _EmployeeInfoDataRepository;
        private IRARecipientRepository _RARecipientRepository;
        private ITemplateRepository _TemplateRepository;
        private IRABatchRecipientRepository _RABatchRecipientRepository;
        private INotificationRepository _NotificationRepository;
        private IRABatchRecipientRuleRepository _RABatchRecipientRuleRepository;

        public RABatchService(IRABatchRepository _RABatchRepository, IRAScheduleRepository _RAScheduleRepository, IRABatchScheduleRepository _RABatchScheduleRepository, IEmployeeInfoDataRepository _EmployeeInfoDataRepository, IRARecipientRepository _RARecipientRepository,
            ITemplateRepository _TemplateRepository, IRABatchRecipientRepository _RABatchRecipientRepository, INotificationRepository _NotificationRepository, IRABatchRecipientRuleRepository _RABatchRecipientRuleRepository)
        {
            this._RABatchRepository = _RABatchRepository;
            this._RAScheduleRepository = _RAScheduleRepository;
            this._RABatchScheduleRepository = _RABatchScheduleRepository;
            this._EmployeeInfoDataRepository = _EmployeeInfoDataRepository;
            this._RARecipientRepository = _RARecipientRepository;
            this._TemplateRepository= _TemplateRepository;
            this._RABatchRecipientRepository = _RABatchRecipientRepository;
            this._NotificationRepository = _NotificationRepository;
            this._RABatchRecipientRuleRepository = _RABatchRecipientRuleRepository;
        }
        

        //Add and Update RABatch
        public RABatchView CreateBatch(RABatchView Batch)
        {
            RABatchView oBatch = new RABatchView();
            RASchedule rASchedule = new RASchedule();

            if (Batch.Id == 0)
            {
                //Add RABatch
                oBatch.Status = "Active";
                oBatch = _RABatchRepository.AddData(Batch);                 
                //Add RASchedule
                rASchedule.ScheduleDate = Batch.RASchedule.ScheduleDate;
                rASchedule.Status = "Active";
                rASchedule.CreatedBy = Batch.CreatedBy;
                //Add RAScheduleMap
                RABatchSchedule rABatchSchedule = new RABatchSchedule();
                rABatchSchedule.BatchId = oBatch.Id;
                List<Employee> Emp = new List<Employee>();
                RABatchRecipientRule rARecipientRule = new RABatchRecipientRule();
                rARecipientRule.BatchId= oBatch.Id;
                rARecipientRule.RecipientRuleId = Batch.RAbatchRecRule.RecipientRuleId;
                rARecipientRule = _RABatchRecipientRuleRepository.AddData(rARecipientRule);
                int Recipientcount = 0;             
                switch (Batch.RAbatchRecRule.RecipientRuleId)
                {
                    case 1:
                        Emp = _EmployeeInfoDataRepository.GetClassifiedEmployee();
                        Recipientcount = Emp.Count;

                        rASchedule.TotalRecipient = Recipientcount;
                        rASchedule = _RAScheduleRepository.AddData(rASchedule);
                        rABatchSchedule.RAScheduleId = rASchedule.Id;
                        rABatchSchedule = _RABatchScheduleRepository.AddData(rABatchSchedule);

                        if (Emp.Count != 0)
                        {
                            foreach (var employee in Emp)
                            {                             
                                RARecipient recipient = new RARecipient();
                                recipient.EmployeeName = employee.FirstName + " " +employee.LastName;
                                recipient.EmployeeEmail = employee.OIDEmailAddress;
                                recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                recipient.Status ="Active";
                                recipient.CreatedOn = DateTime.Now;
                                var addrecipient = _RARecipientRepository.AddData(recipient);

                               
                                RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                raBatchRecipientMap.BatchId= oBatch.Id;
                                raBatchRecipientMap.RecipientId = recipient.Id;
                               var  AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);

                                List<Template> temp = _TemplateRepository.GetTempalteByRule(Batch.RAbatchRecRule.RecipientRuleName);

                                Notification notify = new Notification();
                                notify.EmployeeNumber = employee.EmployeeNumberCode;
                                notify.NotifyTo = employee.OIDEmailAddress;
                                notify.NotifySubject = Batch.BatchName;
                                notify.NotifyFrom = "maran.m@kosoft.co";
                                notify.NotifyStatus = "To Email";
                                notify.NotifyBody = temp[0].TemplateBodyContent;
                                notify.RequestType = "Email";
                                var AddNotifation = _NotificationRepository.AddData(notify);                               
                            }
                        }
                        break;

                    case 2:
                        Emp = _EmployeeInfoDataRepository.GetUnclassifiedEmployee();
                        Recipientcount = Emp.Count;

                        rASchedule.TotalRecipient = Recipientcount;
                        rASchedule = _RAScheduleRepository.AddData(rASchedule);
                        rABatchSchedule.RAScheduleId = rASchedule.Id;
                        rABatchSchedule = _RABatchScheduleRepository.AddData(rABatchSchedule);

                        if (Emp.Count != 0)
                        {
                            foreach (var employee in Emp)
                            {
                                RARecipient recipient = new RARecipient();
                                recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                recipient.EmployeeEmail = employee.OIDEmailAddress;
                                recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                recipient.Status = "Active";
                                recipient.CreatedOn = DateTime.Now;
                                var addrecipient = _RARecipientRepository.AddData(recipient);


                                RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                raBatchRecipientMap.BatchId = oBatch.Id;
                                raBatchRecipientMap.RecipientId = recipient.Id;
                                var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);

                                List<Template> temp = _TemplateRepository.GetTempalteByRule(Batch.RAbatchRecRule.RecipientRuleName);

                                Notification notify = new Notification();
                                notify.EmployeeNumber = employee.EmployeeNumberCode;
                                notify.NotifyTo = employee.OIDEmailAddress;
                                notify.NotifySubject = Batch.BatchName;
                                notify.NotifyFrom = "maran.m@kosoft.co";
                                notify.NotifyStatus = "To Email";
                                notify.NotifyBody = temp[0].TemplateBodyContent;
                                notify.RequestType = "Email";
                                var AddNotifation = _NotificationRepository.AddData(notify);
                            }
                        }
                        break;
                    case 3:
                        Emp = _EmployeeInfoDataRepository.GetTeacherAssitantEmployee();
                        Recipientcount = Emp.Count;

                        rASchedule.TotalRecipient = Recipientcount;
                        rASchedule = _RAScheduleRepository.AddData(rASchedule);
                        rABatchSchedule.RAScheduleId = rASchedule.Id;
                        rABatchSchedule = _RABatchScheduleRepository.AddData(rABatchSchedule);

                        if (Emp.Count != 0)
                        {
                            foreach (var employee in Emp)
                            {
                                RARecipient recipient = new RARecipient();
                                recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                recipient.EmployeeEmail = employee.OIDEmailAddress;
                                recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                recipient.Status = "Active";
                                recipient.CreatedOn = DateTime.Now;
                                var addrecipient = _RARecipientRepository.AddData(recipient);


                                RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                raBatchRecipientMap.BatchId = oBatch.Id;
                                raBatchRecipientMap.RecipientId = recipient.Id;
                                var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);

                                List<Template> temp = _TemplateRepository.GetTempalteByRule(Batch.RAbatchRecRule.RecipientRuleName);

                                Notification notify = new Notification();
                                notify.EmployeeNumber = employee.EmployeeNumberCode;
                                notify.NotifyTo = employee.OIDEmailAddress;
                                notify.NotifySubject = Batch.BatchName;
                                notify.NotifyFrom = "maran.m@kosoft.co";
                                notify.NotifyStatus = "To Email";
                                notify.NotifyBody = temp[0].TemplateBodyContent;
                                notify.RequestType = "Email";
                                var AddNotifation = _NotificationRepository.AddData(notify);
                            }
                        }
                        break;
                    case 4:
                        Emp = _EmployeeInfoDataRepository.GetSpecialEducation();
                        Recipientcount = Emp.Count;

                        rASchedule.TotalRecipient = Recipientcount;
                        rASchedule = _RAScheduleRepository.AddData(rASchedule);
                        rABatchSchedule.RAScheduleId = rASchedule.Id;
                        rABatchSchedule = _RABatchScheduleRepository.AddData(rABatchSchedule);

                        if (Emp.Count != 0)
                        {
                            foreach (var employee in Emp)
                            {
                                RARecipient recipient = new RARecipient();
                                recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                recipient.EmployeeEmail = employee.OIDEmailAddress;
                                recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                recipient.Status = "Active";
                                recipient.CreatedOn = DateTime.Now;
                                var addrecipient = _RARecipientRepository.AddData(recipient);


                                RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                raBatchRecipientMap.BatchId = oBatch.Id;
                                raBatchRecipientMap.RecipientId = recipient.Id;
                                var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);

                                List<Template> temp = _TemplateRepository.GetTempalteByRule(Batch.RAbatchRecRule.RecipientRuleName);

                                Notification notify = new Notification();
                                notify.EmployeeNumber = employee.EmployeeNumberCode;
                                notify.NotifyTo = employee.OIDEmailAddress;
                                notify.NotifySubject = Batch.BatchName;
                                notify.NotifyFrom = "maran.m@kosoft.co";
                                notify.NotifyStatus = "To Email";
                                notify.NotifyBody = temp[0].TemplateBodyContent;
                                notify.RequestType = "Email";
                                var AddNotifation = _NotificationRepository.AddData(notify);
                            }
                        }
                        break;
                    case 5:
                        Emp = _EmployeeInfoDataRepository.GetSupportSchool();
                        Recipientcount = Emp.Count;

                        rASchedule.TotalRecipient = Recipientcount;
                        rASchedule = _RAScheduleRepository.AddData(rASchedule);
                        rABatchSchedule.RAScheduleId = rASchedule.Id;
                        rABatchSchedule = _RABatchScheduleRepository.AddData(rABatchSchedule);

                        if (Emp.Count != 0)
                        {
                            foreach (var employee in Emp)
                            {
                                RARecipient recipient = new RARecipient();
                                recipient.EmployeeName = employee.FirstName + " " + employee.LastName;
                                recipient.EmployeeEmail = employee.OIDEmailAddress;
                                recipient.EmployeeNumber = employee.EmployeeNumberCode;
                                recipient.Status = "Active";
                                recipient.CreatedOn = DateTime.Now;
                                var addrecipient = _RARecipientRepository.AddData(recipient);


                                RABatchRecipient raBatchRecipientMap = new RABatchRecipient();
                                raBatchRecipientMap.BatchId = oBatch.Id;
                                raBatchRecipientMap.RecipientId = recipient.Id;
                                var AddraBatchRecipientMap = _RABatchRecipientRepository.AddData(raBatchRecipientMap);

                                List<Template> temp = _TemplateRepository.GetTempalteByRule(Batch.RAbatchRecRule.RecipientRuleName);

                                Notification notify = new Notification();
                                notify.EmployeeNumber = employee.EmployeeNumberCode;
                                notify.NotifyTo = employee.OIDEmailAddress;
                                notify.NotifySubject = Batch.BatchName;
                                notify.NotifyFrom = "maran.m@kosoft.co";
                                notify.NotifyStatus = "To Email";
                                notify.NotifyBody = temp[0].TemplateBodyContent;
                                notify.RequestType = "Email";
                                var AddNotifation = _NotificationRepository.AddData(notify);
                            }
                        }
                        break;                  
                }                             
            }



            return Batch;

        }

        //Get AllRABatch 
        public IEnumerable<RABatchView> GetAllRABatch()
        {
            return _RABatchRepository.GetAllRABatch();
        }
        
        public RABatchView GetRABatchbyID(int Id)
        {
            return _RABatchRepository.GetSingle(Id);
        }



        //Get RABatchby By RABatchby_Id

        public RABatchViewModel GetBatchViewbyID(int Batchid)
        {
            return _RABatchRepository.GetBatchViewbyID(Batchid);
        }

        //Get Notfication list by BatchID

        public List<RANotificationViewModel> GetRANotificationList(int Batchid)
        {
            return _RABatchRepository.GetRANotificationList(Batchid);
        }

    }
}
