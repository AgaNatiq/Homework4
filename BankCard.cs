using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qaralama
{
    public class BankCard
    {
        public string BankName { get; set; }
        public string CardHolder { get; set; }
        public long CardNumber { get; set; }
        public int CVV { get; set; }
        public string ExpDate { get; set; }
        public decimal CardBalance { get; set; }

        public void IncreaseBalance(decimal amount)
        {
            if (amount < 0)
                return;
            CardBalance += amount;
        }

        public void DecreaseBalance(decimal amount)
        {
            if (amount < 0)
                return;
            if (amount > CardBalance);
            CardBalance -= amount;
        }
    }
}
