using HomeAccounting.DataSource.Contract.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.DataSource.Contract
{
    public interface IRepository
    {
        void CreateAccount(DbAccount account);

        void SaveAccount(DbAccount account);

        DbAccount GetAccountById(int id);
    }
}
