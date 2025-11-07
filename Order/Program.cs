using Order;
using System.Numerics;

namespace FirstApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            HomeDelivery homeDelivery = new HomeDelivery(3, "г Москва, ул Ленина 50");
            OrderProduct<HomeDelivery, DigitalTechnplogy> orderProduct = new OrderProduct<HomeDelivery, DigitalTechnplogy>(homeDelivery, "Доставить в будни до 13:00");

            Phone phone = new Phone(512, null, "Huawei Kirin 9020 2.4 ГГц", 8, "Смартфон HUAWEI Pura 80 Pro", 89_999, 10_000);
            orderProduct.Products[0] = phone;

            OrderProduct<HomeDelivery, DigitalTechnplogy> newOrderProduct = ++orderProduct;
        }
    }
}