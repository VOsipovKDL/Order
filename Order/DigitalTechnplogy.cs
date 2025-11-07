namespace Order
{
    internal abstract class DigitalTechnplogy : Product
    {
        public string? Processor { get; set; }

        public int CoreNumber { get; set; }

        public DigitalTechnplogy() { }

        public DigitalTechnplogy(string processor, int coreNumber, string name, int originalPrice, int discountAmount)
            : base(name, originalPrice, discountAmount)
        {
            Processor   = processor;
            CoreNumber  = coreNumber;
        }
    }
}
