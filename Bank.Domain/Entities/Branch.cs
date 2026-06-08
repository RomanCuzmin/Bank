using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель отделения банка
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string WorkingHours { get; set; }
        public bool IsActive { get; set; } = true;
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
    }
}
