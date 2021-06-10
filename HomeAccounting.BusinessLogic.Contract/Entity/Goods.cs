using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract.Entity
{
    //материальные вещи(например машина)
    public class Goods : Account
    {
        //когда купили
        public DateTime IncomeDate { get; set; }

        //почем купили 
        public decimal IncomeSum { get; set; }
    }
}
