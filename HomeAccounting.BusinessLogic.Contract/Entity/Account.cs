using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.Entity
{
    public class Account : Entity
    {
        public decimal Value { get; set; }

        public AccountType Type { get; set; }
    }
}