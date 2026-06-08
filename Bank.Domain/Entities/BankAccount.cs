using Bank.Domain.Entities.Base;
using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Bank.Domain.Entities
{
    //Модель банковского счета
    public class BankAccount : BasicModelWithModifications
    {
        private string _accountName;
        private decimal? _balance;
        public int Id { get; set; }
        public int UserId { get; set; }
        public Client Client { get; set; }
        public BalanceAccountNumberType TypeAmount { get; set; }
        public CurrencyCode Currency { get; set; }
        public string TheCheckDigit { get; set; }
        public CodeOfTheBankDivision CodeOfTheDivision { get; set; }
        public string InternalAccountNumber { get; set; }

        public decimal? Balance
        {
            get => _balance;
            set => SetField(ref _balance, value);
        }

        public string AccountName
        {
            get => _accountName;
            set => SetField(ref _accountName, value);
        }

        public ICollection<BankCard> BankCards { get; set; } = new List<BankCard>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public string FullNumber => TypeAmount.ToString() + Currency.ToString() + TheCheckDigit + CodeOfTheDivision.ToString() + InternalAccountNumber;
    }
}
