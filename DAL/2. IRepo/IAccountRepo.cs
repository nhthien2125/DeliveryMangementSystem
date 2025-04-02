using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryMangementSystem.Models;

namespace DAL._2._IRepo
{
    interface IAccountRepo
    {
        Task<Account> GetAccountByUsername(string username);
        Task<Account> GetAccountById(string A_ID);
        Task AddAsync(Account account);
        Task UpdateAsync(Account account);
        Task DeleteAsync(string A_ID);
    }
}
