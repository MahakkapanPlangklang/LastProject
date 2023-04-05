using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastProject
{
    public class Payments
    {

        public double paymentAmount;
        public string paymentDate;
        public string table;

        public Payments(double paymentAmount, string paymentDate, string table)
        {
            this.paymentAmount = paymentAmount;
            this.paymentDate = paymentDate;
            this.table = table;
        }

        public string Table { get => table; }
        public string Date { get => paymentDate; }
        public double Amount { get => paymentAmount; }
    }
} 
