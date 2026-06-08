using Bank.Domain.Entities.Base;
using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель транзакции 
    public class Transaction : BasicModelWithModifications
    {
        private string _description;
        private StatusTransaction _statusTransaction;

        public int Id { get; set; }
        public int AccountId { get; set; }
        public BankAccount Account { get; set; }

        public string Description
        {
            get => _description;
            set => SetField(ref _description, value);
        }

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }

        public StatusTransaction Status
        {
            get => _statusTransaction;
            set => SetField(ref _statusTransaction, value);
        }

        public string? CategoryIcon { get; set; }
        public string? CategoryColor { get; set; }
    }
}
