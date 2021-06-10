using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.Entity
{
    public class Bank : Entity
    {
        public string Bic { get; set; }

        public string CorrAccount { get; set; }
    }
}
