namespace Order
{
    internal class DeliveryCompany
    {
        private string Name;

        private long Inn;

        private long Kpp;

        private long Ogrn;

        public DeliveryCompany(string name, long inn, long kpp, long ogrn)
        {
            Name = name;
            Inn = inn;
            Kpp = kpp;
            Ogrn = ogrn;
        }

        public string GetCompanyInfo()
        {
            return "компания: "+Name+" (ИНН "+Inn+", КПП "+Kpp+", ОГРН "+Ogrn+").";
        }
    }
}
