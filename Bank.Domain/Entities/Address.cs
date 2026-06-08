using Bank.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель адреса 
    public class Address : BasicModelWithModifications
    {
        private DateTime _registrationDate;
        private string _area;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;
        private string _code;

        public int Id { get; set; }
        public int UserId { get; set; }

        public DateTime RegistrationDate
        {
            get => _registrationDate;
            set => SetField(ref _registrationDate, value);
        }

        public string Area
        {
            get => _area;
            set => SetField(ref _area, value);
        }

        public string City
        {
            get => _city;
            set => SetField(ref field, value);
        }

        public string Street
        {
            get => _street;
            set => SetField(ref _street, value);
        }

        public string Building
        {
            get => _building;
            set => SetField(ref _building, value);
        }

        public string Apartment
        {
            get => _apartment;
            set => SetField(ref _apartment, value);
        }

        public string Code
        {
            get => _code;
            set => SetField(ref _code, value);
        }

        public Admin Admin { get; set; }
        public Client Client { get; set; }
    }
}
