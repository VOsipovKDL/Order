namespace Order
{
    internal static class DateTimeExtensions
    {
        public static string GetStringOrderNumber(this DateTime date)
        {
            string numberPostfixList = "ABCDEF";
            Random rnd = new Random();
            char numberPostfix = numberPostfixList[rnd.Next(numberPostfixList.Length-1)];
            return date.Ticks.ToString() + numberPostfix;
        }
    }
}
