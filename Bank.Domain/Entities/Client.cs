using Bank.Domain.Entities.Base;
using Bank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель клиента
    public class Client : BasicModelWithModifications
    {
        private string _loginName;
        private string _password;
        private PassportData _passport;
        private PersonalData _personal;
        private Address _address;
        private NotificationType _notificationType;
        private bool _isVerification;

        public int Id { get; set; }

        public string LoginName
        {
            get => _loginName;
            set => SetField(ref _loginName, value);
        }

        public string Password
        {
            get => _password;
            set => SetField(ref _password, value);
        }

        public PassportData Passport
        {
            get => _passport;
            set => SetField(ref _passport, value);
        }

        public PersonalData Personal
        {
            get => _personal;
            set => SetField(ref _personal, value);
        }

        public Address Addres
        {
            get => _address;
            set => SetField(ref _address, value);
        }

        public NotificationType Notification
        {
            get => _notificationType;
            set => SetField(ref _notificationType, value);
        }


        public bool IsVerification
        {
            get => _isVerification;
            set => SetField(ref _isVerification, value);
        }

        public List<Application> Applications { get; set; }
    }
}
