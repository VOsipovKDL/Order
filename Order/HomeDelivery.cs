using System.Net;

namespace Order
{
    internal class HomeDelivery : Delivery
    {
        private Courier Courier;

        private DateTime DeliveryDateFrom;

        private DateTime DeliveryDateBefore;

        public HomeDelivery(int delivaryDay, string address) : base(address)
        {
            Courier = new Courier("Иван");
            DeliveryDateFrom = DateTime.Now;
            DeliveryDateBefore = DeliveryDateFrom.AddDays(delivaryDay);
        }

        public override string GеtDeliveryInfo()
        {
            return "Адрес доставки: "+Address+". Доставит "+Courier.GetCourierInfo()+" Ориентировочное время доставки с "+DeliveryDateFrom+" до "+DeliveryDateBefore;
        }
    }
}
