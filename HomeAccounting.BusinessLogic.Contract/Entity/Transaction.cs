using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.Entity
{
    public class Transaction : Entity
    {
        OperationType Type { get; set; }

        public decimal Amount { get; set; }

        public Currency Currency { get; set; }

        public Account PayerAsset { get; set; }

        public string PayerDescription { get; set; }

        public Account ReceiverAsset { get; set; }

        public string ReceiverDescription { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
