using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace budgy.Models
{
    public class Budget
    {
        public int BudgetId { get; set; }
        public int Indkomst { get; set; }
        public int Mad { get; set; }
        public int Hus { get; set; }
        
    }
}