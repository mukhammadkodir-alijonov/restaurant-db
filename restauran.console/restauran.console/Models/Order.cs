using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.console.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int TableName { get; set; }
        public double TotalSum { get; set; }
        public string OrderDate { get; set; } = string.Empty;
        public int NumberCount { get; set; }
        public int EmployeeId { get; set; }
    }
}
