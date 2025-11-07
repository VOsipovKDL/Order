using Order;
using System;
using System.Numerics;
using System.Xml.Linq;

namespace FirstApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Тут не применить инициализатор объектов - внутри конструктора есть логика, тогда и логику выносить придётся
            //Которую в этом классе знать не нужно
            HomeDelivery homeDelivery = new HomeDelivery(3, "г Москва, ул Ленина 50");

            //У останльных двух классов переделал под инициализатор объектов
            //В чём приимущество я не понял - сравните пожалуйста с предыдущим комитом, их тут всего 2 и напишите пожалуйста,
            // чем вот этот способ лучше вызова конструктора, который позволяет закрыть переменные класса для доступа извне?
            OrderProduct<HomeDelivery, DigitalTechnplogy> orderProduct = new OrderProduct<HomeDelivery, DigitalTechnplogy>
            {
                Comment = "Доставить в будни до 13:00",
                Delivery = homeDelivery,
            };

            Phone phone = new() {
                Memory = 512,
                MemoryCardType = null,
                Processor = "Huawei Kirin 9020 2.4 ГГц",
                CoreNumber = 8,
                Name = "Смартфон HUAWEI Pura 80 Pro",
                OriginalPrice = 89_999,
                discountAmount = 10_000,
            };

            orderProduct.Products[0] = phone;

            OrderProduct<HomeDelivery, DigitalTechnplogy> newOrderProduct = ++orderProduct;
        }
    }
}