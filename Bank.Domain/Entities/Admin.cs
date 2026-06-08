using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Bank.Domain.Entities
{
    //Модель админа
    public class Admin
    {
        public int Id { get; set; }
        public string ServiceNumber { get; set; }
        public int PassportDataId { get; set; }
        public PassportData PassportData { get; set; }
        public int PersonalDataId { get; set; }
        public PersonalData PersonalData { get; set; }
        public int AddresId { get; set; }
        public Address Addres { get; set; }
        public ICollection<Application> Applications = new List<Application>();
    }
}
