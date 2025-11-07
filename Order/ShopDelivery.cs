namespace Order
{
    internal class ShopDelivery : Delivery
    {
        private DateTime DateReceipt;

        private int CodeReceive;

        public ShopDelivery(int codeReceive, string address) : base(address)
        {
            DateReceipt = DateTime.Now.AddDays(7);
            CodeReceive = codeReceive;
        }

        public override string GеtDeliveryInfo()
        {
            return "Адрес магазина: "+Address+". Дата получения: "+DateReceipt+", код для получения: "+CodeReceive;
        }
    }
}
