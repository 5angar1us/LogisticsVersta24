
using LogisticsVersta24.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticsVersta24.Persistance
{
    public class DBInitialazer
    {
        public static void Initialize(ApplicationDBcontext DBcontext)
        {
            if (DBcontext.Database.EnsureCreated())
            {
                CreateDefault(DBcontext);
            }
        }

        private static void CreateDefault(ApplicationDBcontext DBcontext)
        {
            var order1 = new Order(
                "Ярославль",
                "Улица пушкина дом покатушкина",
                "Москва",
                "Главная площадь города",
                5000,
                DateTime.Today
                );

            var order2 = new Order(
                "Мурманск",
                "Улица Октябрская 20",
                "Москва",
                "Главная площадь города",
                5000,
                DateTime.Today
                );

            DBcontext.Orders.Add(order1);
            DBcontext.Orders.Add(order2);
            DBcontext.SaveChanges();
        }
    }
}
