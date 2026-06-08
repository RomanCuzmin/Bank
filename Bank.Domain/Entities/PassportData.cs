using Bank.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bank.Domain.Entities
{
    //Модель паспортных данных 
    public class PassportData : BasicModelWithModifications
    {
        private string _passportIssued;
        private string _unitCode;
        private DateTime _dateOfIssue;
        private string _series;
        private string _number;
        public int Id { get; set; }
        public int UserId { get; set; }
        public Client? Client { get; set; }
        public Admin? Admin { get; set; }

        public string PassportIssued
        {
            get => _passportIssued;
            set => SetField(ref _passportIssued, value);
        }

        public string UnitCode
        {
            get => _unitCode;
            set => SetField(ref _unitCode, value);
        }

        public DateTime DateOfIssue
        {
            get => _dateOfIssue;
            set => SetField(ref _dateOfIssue, value);
        }

        public string Series
        {
            get => _series;
            set => SetField(ref _series, value);
        }

        public string Number
        {
            get => _number;
            set => SetField(ref _number, value);
        }

        public string SeriesNumber => $"{Series} {Number}".Trim();

        public string MaskedNumber => !string.IsNullOrEmpty(Series) && !string.IsNullOrEmpty(Number)
            ? $"{Series} {Number.Substring(0, 2)}** ***"
            : string.Empty;

        public override string ToString() => $"Паспорт: {MaskedNumber}, выдан: {DateOfIssue:dd.MM.yyyy}";
    }
}
