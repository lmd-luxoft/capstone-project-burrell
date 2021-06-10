using HomeAccounting.BusinessLogic.Contract.Entity;
using HomeAccounting.BusinessLogic.Contract.Interfaces;
using HomeAccounting.DataSource.Contract;
using HomeAccounting.DataSource.Contract.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic
{
    public class AccountingService : IAccounting
    {
        private readonly IRepository _repo;

        public AccountingService(IRepository repo)
        {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        public void CreateAccount(Account account)
        {
            var dto = MapEntityToDto(account);
        }

        private static DbAccount MapEntityToDto(Account account)
        {
            var dto = new DbAccount()
            {
                Id = account.Id,
                CreationDate = account.CreationDate,
                Name = account.Name,
                Description = account.Description
            };

            return dto;
        }

        public Account GetAccountById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
