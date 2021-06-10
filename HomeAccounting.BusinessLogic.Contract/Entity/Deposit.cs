using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.Entity
{
    public class Deposit : Account
    {
        public Bank Bank { get; set; }

        public string AccountNumber { get; set; }
    }
}
