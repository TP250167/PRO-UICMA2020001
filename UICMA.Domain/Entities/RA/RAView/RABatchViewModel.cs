using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UICMA.Domain.Entities.RA.RAView
{

    public class RABatchViewModel
    {
        [Key]
        
        public Int64 Id { get; set; }
       
        public string Batch_Name { get; set; }
       
        public string Batch_Description { get; set; }
        public string Status { get; set; }
        public int? Total_Recipient { get; set; }
        public int? Sucessful_Delivery { get; set; }
        public DateTime? Schedule_Date { get; set; }
        public int? Failed_Delivery { get; set; }
       
    }
}

