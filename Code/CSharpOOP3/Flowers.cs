namespace CSharpOOP3
{
    public class Flowers  //Task_01
    {
        public string Color //(setter-only property)
        {
            set { Color = value; }
        }

        public double Price { get { return Price; } }  //(read-only property)

        public string Name//(Task_03)
        {
            get { return Name; }
            private set { Name = value; }
        }
        public static string Type { get; set; }

        public static double CalculateTotalPrice(Flowers[] flowersArray)// (Task_5)
        {
            double totalPrice = 0;

            foreach (Flowers flower in flowersArray)
            {
                totalPrice += flower.Price;
            }

            return totalPrice;
        }



    }    
}
