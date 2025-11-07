namespace Order
{
    internal abstract class Product
    {
        public string? Name { get; set; }

        public int OriginalPrice { get; set; }

        public int TotalPrice { get; set; }

        public int discountAmount { get; set; }

        public int DiscountAmount
        {
            get { return discountAmount; }
            set
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

        public Product() { }

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
