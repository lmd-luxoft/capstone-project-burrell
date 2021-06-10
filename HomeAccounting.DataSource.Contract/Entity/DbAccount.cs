using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.DataSource.Contract.Entity
{
    public class DbAccount : DbEntity
    {
        public decimal Value { get; set; }        
    }
}
