namespace Order
{
    internal class Courier
    {
        private string Name;

        private double Rating;

        public Courier(string name)
        {
            Name    = name;
            Rating  = 5.0;
        }

        public string GetCourierInfo()
        {
            return "курьер: "+Name+", рейтинг: "+Rating+".";
        }

        public void UpRating()
        {
            if (Rating<5) Rating += 0.01;
        }

        public void DownRating()
        {
            if (Rating>0) Rating -= 0.01;
        }
    }
}
