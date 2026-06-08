using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель предложения по продукту 
    public class ProductOffer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public TypeProductOffer TypeOffer { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? CreditLimit { get; set; }
        public bool IsPopular { get; set; }
        public string? BackgroundCollor { get; set; }
    }
}
