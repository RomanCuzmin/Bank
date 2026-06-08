using Bank.Domain.Entities.Base;
using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель вклада
    public class Deposit : BasicModelWithModifications
    {
        private int _theAmount;
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int TheAmount
        {
            get => _theAmount;
            set => SetField(ref _theAmount, value);
        }

        public uint TheInterestRate { get; set; }
        public TheMethodOfInterestAccrual MethodOfInterestAccrual { get; set; }
        public TypeOfDeposit Type { get; set; }
        public uint MinimumBalance { get; set; }
    }
}
