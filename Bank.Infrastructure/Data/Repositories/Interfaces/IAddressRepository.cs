using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bank.Infrastructure.Data.Repositories.Interfaces
{
    public interface IAddressRepository
    {
        public Task<List<Address>> GetAllAddreses();
        public Task<Address> AddAddress(DateTime registrationDate, string area, string city, string street, string building, string appartment, string code);
        public Task<Address> GetAddressById(int id);
        public Task<Address> GetAddresByUserId(int userId);
        public Task Delete(Address addressToDelete);

    }
}
