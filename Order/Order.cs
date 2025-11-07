
namespace Order
{
    abstract class Order<T>
    {
        private T Number;

        public Order(T number)
        {
            Number = number;
        }

        public T GetOrderNumber()
        {
            return Number;
        }
    }
}
