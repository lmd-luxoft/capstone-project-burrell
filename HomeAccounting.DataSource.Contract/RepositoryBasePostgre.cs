using HomeAccounting.DataSource.Contract.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.DataSource.Contract
{
    public class RepositoryBasePostgre : IRepository
    {
        public void CreateAccount(DbAccount account)
        {
            throw new NotImplementedException();
        }

        public DbAccount GetAccountById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveAccount(DbAccount account)
        {
            throw new NotImplementedException();
        }
    }
}
