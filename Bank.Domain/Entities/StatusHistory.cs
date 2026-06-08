using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель истории изминений заявки
    public class StatusHistory
    {
        public int Id { get; set; }
        public int ApplicationId;
        public Application Application { get; set; }
        public DateTime Date { get; set; }
        public ApplicationStatus Status { get; set; }
        public string Comment { get; set; }
        public string ChangegBy { get; set; }
    }

}
