using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL._2._IRepo;
using DeliveryMangementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL._2._Repo
{
    public class AccountRepo : IAccountRepo
    {
        //Local Attributes
        private readonly myDbContext _context;

        //Constructor
        public AccountRepo()
        {
            _context = new myDbContext();
        }

        //CRUD
        public async Task AddAsync(Account account)
        {
            await _context.Accounts.AddAsync(account);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(string A_ID)
        {
            var account = _context.Accounts.Find(A_ID);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Account> GetAccountById(string A_ID)
        {
            return await _context.Accounts.FindAsync(A_ID);
        }
        public async Task<Account> GetAccountByUsername(string username)
        {
            return await _context.Accounts.FirstOrDefaultAsync(a => a.Username == username);
        }
        public async Task UpdateAsync(Account account)
        {
            _context.Accounts.Update(account);
            await _context.SaveChangesAsync();
        }
    }
}
