namespace Order
{
    internal class PickPointDelivery : Delivery
    {
        private DeliveryCompany DeliveryCompany;

        private DateTime DateReceipt;

        private int CodeReceive;

        public PickPointDelivery(int codeReceive, string address) : base(address)
        {
            DeliveryCompany = new DeliveryCompany("ООО Доставка", 7777777777, 888888888, 9999999999999);
            DateReceipt = DateTime.Now.AddDays(7);
            CodeReceive = codeReceive;
        }

        public override string GеtDeliveryInfo()
        {
            return "Доставка в пункт выдачи: "+Address+". Доставкой занимается "+DeliveryCompany.GetCompanyInfo()+". Дата доставки: "+DateReceipt+", код для получения: "+CodeReceive;
        }
    }
}
