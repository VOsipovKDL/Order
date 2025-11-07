namespace Order
{
    internal abstract class DigitalTechnplogy : Product
    {
        protected string Processor;

        protected int CoreNumber;

        public DigitalTechnplogy(string processor, int coreNumber, string name, int originalPrice, int discountAmount)
            : base(name, originalPrice, discountAmount)
        {
            Processor   = processor;
            CoreNumber  = coreNumber;
        }
    }
}
