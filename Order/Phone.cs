using System.Diagnostics;
using System.Xml.Linq;

namespace Order
{
    internal class Phone : DigitalTechnplogy
    {
        public int Memory { get; set; }

        public string? memoryCardType { get; set; }

        public string? MemoryCardType
        {
            get { return (memoryCardType==null) ? "отсутствует" : memoryCardType; }
            set { memoryCardType = value; }
        }

        public Phone() { }

        public Phone(int memory, string? memoryCardType, string processor, int coreNumber, string name, int originalPrice, int discountAmount)
            : base(processor, coreNumber, name, originalPrice, discountAmount)
        {
            Memory         = memory;
            MemoryCardType = memoryCardType;
        }

        public override string GetName()
        {
            return Name + " " + Memory;
        }

        public string GetProductInfo()
        {
            string fullName = this.GetName();
            return fullName+" Процессор: "+Processor+", количество ядер: "+CoreNumber+" Цена: "+OriginalPrice+" с учетом скидки: "+TotalPrice;
        }
    }
}
