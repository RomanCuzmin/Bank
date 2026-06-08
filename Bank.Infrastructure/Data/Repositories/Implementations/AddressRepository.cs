using Bank.Domain.Entities;
using Bank.Infrastructure.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Infrastructure.Data.Repositories.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        private readonly BankDbContext _context;

        //Конструктор
        public AddressRepository(BankDbContext context)
            => _context = context;

        //Добавление адреса 
        public async Task<Address> AddAddress(DateTime registrationDate, string area, string city, string street, string building, string appartment, string code)
        {
            var address = new Address
            {
                RegistrationDate = registrationDate,
                Area = area,
                City = city,
                Street = street,
                Building = building,
                Apartment = appartment,
                Code = code
            };

            await _context.Addresses.AddAsync(address);
            await _context.SaveChangesAsync();
            return address;
        }

        //Получение всех адресов
        public async Task<List<Address>> GetAllAddreses()
            => await _context.Addresses.ToListAsync();

        //Получение адреса по id пользователя
        public async Task<Address> GetAddresByUserId(int userId)
            => await _context.Addresses.SingleOrDefaultAsync(a => a.UserId == userId);

        //Получение адреса по id
        public async Task<Address> GetAddressById(int id)
            => await _context.Addresses.SingleOrDefaultAsync(a => a.Id == id);

        //Удаление адреса
        public async Task Delete(Address addressToDelete)
        {
            _context.Addresses.Remove(addressToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
