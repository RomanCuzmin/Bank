using Bank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Bank.Infrastructure
{
    public class BankDbContext : DbContext
    {
        //DbSetы
        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<Admin> Admins => Set<Admin>();
        public DbSet<Application> Applications => Set<Application>();
        public DbSet<BankAccount> BankAccounts => Set<BankAccount>();
        public DbSet<BankCard> BankCards => Set<BankCard>();
        public DbSet<Branch> Branches => Set<Branch>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Deposit> Deposits => Set<Deposit>();
        public DbSet<Document > Documents => Set<Document>();
        public DbSet<Loan> Loans => Set<Loan>();
        public DbSet<LoanPayment> LoanPayments => Set<LoanPayment>();
        public DbSet<PassportData> PassportData => Set<PassportData>();
        public DbSet<PersonalData> PersonalData => Set<PersonalData>();
        public DbSet<ProductOffer> ProductOffers => Set<ProductOffer>();
        public DbSet<StatusHistory> StatusHistories => Set<StatusHistory>();
        public DbSet<Transaction> Transactions => Set<Transaction>();

        //Конструктор 
        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
        {

        }
    }
}
