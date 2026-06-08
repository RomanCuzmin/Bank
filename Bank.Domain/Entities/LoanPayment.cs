using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель платежа по кредиту
    public class LoanPayment
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public Loan Loan { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public decimal PrincipalAmount { get; set; }
        public decimal InterestAmount { get; set; }
        public bool IsOnTime { get; set; }
    }
}
