namespace CSharpOOP3
{
    public class Flower  //Task_01
    {
        private string _color;
        public string Color //(setter-only property)
        {
            set { _color = value; }
        }

        private double _price;
        public double Price { get { return _price; } }  //(read-only property)

        public string Name//(Task_03)
        {
            get { return Name; }
            private set { Name = value; }
        }
        public static string Type { get; set; }

        public static double CalculateBoqueyPrice(double price, int count)// (Task_5)
        {
            double boqueyPrice = price * count;
            return boqueyPrice;
        }



    }    
}
