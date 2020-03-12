using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UICMA.Domain.Entities.RA.RAView
{
    public class RANotificationViewModel
    {
        [Key]

        public Int64 Id { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Number { get; set; }
        public DateTime? Created_on { get; set; }
        public DateTime? Notified_Sent_On { get; set; }
        public DateTime? Delivered_On { get; set; }
        public DateTime? Failed_On { get; set; }       
        public string Delivery_Notice { get; set; }
        public string Status { get; set; }
    }
}
