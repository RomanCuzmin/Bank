using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель банковской карты 
    public class BankCard
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public BankAccount BankAccount { get; set; }
        public TypeOfPaymentSystem PaymentSystem { get; set; }
        public TheIssuingBank IssuingBank { get; set; }
        public string InternalAccountNumber { get; set; }
        public string TheCheckDigit { get; set; }
        public string CVICode { get; set; }
        public string PinCode { get; set; }
        public DateTime ValidUntil { get; set; }
        public int FailedPinAttempts { get; set; }
        public DateTime? LockedUntil { get; set; }
        public DateTime LastPinChange { get; set; }
        public bool RequiresPinChange { get; set; }
        public string FullNumber => PaymentSystem.ToString() + IssuingBank.ToString() + InternalAccountNumber + TheCheckDigit;
        public string DisplayValidUntil => ValidUntil.ToString("MM/yy");
        public bool IsActive => ValidUntil > DateTime.Now && (!LockedUntil.HasValue || LockedUntil < DateTime.Now);
        public bool IsLocked => LockedUntil.HasValue && LockedUntil.Value > DateTime.Now;
    }
}
