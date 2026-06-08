using Bank.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель персональных данных 
    public class PersonalData : BasicModelWithModifications
    {
        private string _surName;
        private string _name;
        private string _patronymic;
        private string _phoneNumber;
        private string _email;
        
        public int Id { get; set; }
        public int UserId { get; set; }
        public Client? Client { get; set; }
        public Admin? Admin { get; set; }

        public string SurName
        {
            get => _surName;
            set => SetField(ref _surName, value);
        }

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public string Patronymic
        {
            get => _patronymic;
            set => SetField(ref _patronymic, value);
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => SetField(ref _phoneNumber, value);
        }

        public string Email
        {
            get => _email;
            set => SetField(ref _email, value);
        }

        public DateTime DateOfBirth { get; set; }
    }
}
