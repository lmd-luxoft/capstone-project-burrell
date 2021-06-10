using HomeAccounting.BusinessLogic.Contract.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.Interfaces
{
    public interface IAccounting
    {
        void CreateAccount(Account account);

        void SaveAccount(Account account);

        Account GetAccountById(int id);
    }
}
