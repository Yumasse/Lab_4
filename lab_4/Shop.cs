using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Shop : ISearchable
    {
        public List<Goods> Goods { get; set; }
        public List<User> User { get; set; }
        public List<Order> Order { get; set; }

        public Shop()
        {
            Goods = new List<Goods>();
            User = new List<User>();
            Order = new List<Order>();
        }

        public void AddGoods(Goods goods)
        {
            Goods.Add(goods);
        }

        public void AddUser(User user)
        {
            User.Add(user);
        }

        public void DoOrder (User user, List<Goods> goods, int amount)
        {
            var order = new Order(goods, amount);
            user.Purchasehistory.Add(order);
            Order.Add(order);
        }

        public List<Goods> Search(decimal minPrice, decimal maxPrice, string category)
        {
            return Goods.Where(goods => goods.Price >= minPrice && goods.Price <= maxPrice &&
                (string.IsNullOrEmpty(category) || goods.Category.Equals(category, StringComparison.OrdinalIgnoreCase))).ToList();
        }

    }
}
