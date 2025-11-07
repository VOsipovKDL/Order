namespace Order
{
    class OrderProduct<TDelivery, TProduct> : Order<string>
        where TDelivery : Delivery
        where TProduct : Product
    {
        public TProduct[] Products { get; private set; }

        public string? Comment { get; set; }

        public TDelivery Delivery { get; set; }

        public OrderProduct() : base(DateTime.Now.GetStringOrderNumber())
        {
            Products = new TProduct[5];
        }

        public OrderProduct(TDelivery delivery, string comment) : base(DateTime.Now.GetStringOrderNumber())
        {
            Delivery = delivery;
            Comment = comment;
            Products = new TProduct[5];
        }

        public OrderProduct(TProduct[] products) : base(DateTime.Now.GetStringOrderNumber())
        {
            Products = products;
        }
        public static OrderProduct<TDelivery, TProduct> operator ++(OrderProduct<TDelivery, TProduct> oldOrder)
        {
            return new OrderProduct<TDelivery, TProduct>(oldOrder.Delivery, oldOrder.Comment);
        }

        public string GetDeliveryInfo()
        {
            return Delivery.GеtDeliveryInfo();
        }

        public TProduct? this[int index]
        {
            get
            {
                if (index >= 0 && index < Products.Length)
                {
                    return Products[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                if (index >= 0 && index < Products.Length)
                {
                    Products[index] = value;
                }
            }
        }

        public int GetProductsOriginalPrice()
        {
            int orderOriginalPrice = 0;
            foreach (var product in Products)
            {
                if (product != null) orderOriginalPrice += product.OriginalPrice;
            }

            return orderOriginalPrice;
        }

        public int GetProductsTotalPrice()
        {
            int orderTotalPrice = 0;
            foreach (var product in Products)
            {
                if (product != null) orderTotalPrice += product.TotalPrice;
            }

            return orderTotalPrice;
        }

        public int GetProductsDiscount()
        {
            int orderDiscount = 0;
            foreach (var product in Products)
            {
                if (product != null) orderDiscount += product.DiscountAmount;
            }

            return orderDiscount;
        }
    }
}
