namespace Order
{
    internal abstract class Product
    {
        protected string Name;

        public int OriginalPrice { get; protected set; }

        public int TotalPrice { get; protected set; }

        private int discountAmount;

        public int DiscountAmount
        {
            get { return discountAmount; }
            protected set
            {
                if (value < 0)
                {
                    discountAmount = 0;
                }
                else
                {
                    discountAmount = value;
                }
            }
        }

        public Product(string name, int originalPrice, int discountAmount)
        {
            Name = name;
            OriginalPrice = originalPrice;
            DiscountAmount = discountAmount;
            TotalPrice = OriginalPrice - DiscountAmount;
        }

        public virtual string GetName()
        {
            return Name;
        }
    }
}
