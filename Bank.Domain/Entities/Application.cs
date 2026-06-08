using Bank.Domain.Entities.Base;
using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель заявки
    public class Application : BasicModelWithModifications
    {
        private DateTime _lastModifiedDate;
        private ApplicationStatus _status;
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime LastModiffiedDate
        {
            get => _lastModifiedDate;
            set => SetField(ref _lastModifiedDate, value);
        }

        public ApplicationStatus Status
        {
            get => _status;
            set => SetField(ref _status, value);
        }

        public CreditType CreditType { get; set; }
        public decimal RequerstedAmount { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public int TermMonts { get; set; }
        public decimal InterestRate { get; set; }
        public int MothlyPayment { get; set; }
        public int DownPayment { get; set; }
        public string Purpose { get; set; }
        public string ManagerComment { get; set; }
        public string RejectionReason { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int BrancId { get; set; }
        public Branch Branch { get; set; }
        public int AdminId { get; set; }
        public Admin AssignedManager { get; set; }
        public List<Document> Documents { get; set; }
        public List<StatusHistory> StatusHistory { get; set; }

        public override string ToString()
        {
            return $"Заявка №{Id} | {Client?.LoginName} | {CreditType} | {Status}";

        }
    }
}