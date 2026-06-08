using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель кредита
    public class Loan
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public Application OriginalApplication { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public decimal OriginalAmount { get; set; }
        public decimal RemainingBalance { get; set; }
        public decimal InterestRate { get; set; }
        public int TotalTermMonths { get; set; }
        public int PaidMonths { get; set; }
        public decimal MonthlyPayment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public decimal NextPaymentAmount { get; set; }
        public bool IsDelinquent { get; set; }
        public int? DelinquentDays { get; set; }
        public StatusCredit Status { get; set; }
        public List<LoanPayment> Payments { get; set; } = new();
    }
}
