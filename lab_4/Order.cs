using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Order
    {
        public List<Goods> Goods { get; set; }

        public int Amount { get; set; }
        public decimal Sum { get; set; }
        public string Status { get; set; }

        public Order(List<Goods> goods, int amount)
        {
            Goods = goods;
            Amount = amount;
            Sum = goods.Sum(goods => goods.Price) * amount;
            Status = "Очікує на відправку";
        }

    }
}
