using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.Entity
{
    public class Asset : Entity
    {
        public decimal Value { get; set; }

        public AssetType Type { get; set; }
    }
}