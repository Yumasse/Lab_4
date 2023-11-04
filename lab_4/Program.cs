namespace lab_4
{
    class Program
    {
        static void Main()
        {
            var shop = new Shop();

            var goods1 = new Goods("Ноутбук", 1000, "Потужний ноутбук", "Електроніка");
            var goods2 = new Goods("Футболка", 20, "Зручна футболка", "Одяг");
            shop.AddGoods(goods1);
            shop.AddGoods(goods2);

            var user = new User("user1", "password1");
            shop.AddUser(user);

            shop.DoOrder(user, new List<Goods> { goods1, goods2 }, 2);

            Console.WriteLine("Історія покупок користувача:");

            foreach (var order in user.Purchasehistory)
            {
                Console.WriteLine($"Замовлення: Загальна вартість - {order.Sum}, Статус - {order.Status}");
            }

            Console.WriteLine("\nПошук товарів за критеріями:");

            var searchResults = shop.Search(0, 50, "Одяг");
            foreach (var goods in searchResults)
            {
                Console.WriteLine($"Товар: {goods.Name}, Ціна - {goods.Price}, Категорія - {goods.Category}");
            }

        }
    }
}