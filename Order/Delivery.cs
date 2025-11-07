namespace Order
{
    internal abstract class Delivery
    {
        protected string Address { get; set; }

        protected Delivery(string address)
        {
            Address = address;
        }

        public virtual string GеtDeliveryInfo()
        {
            return "Адрес доставки: "+Address;
        }
    }
}
