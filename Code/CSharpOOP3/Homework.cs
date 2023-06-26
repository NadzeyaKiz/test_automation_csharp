namespace CSharpOOP3
{
    public class Flower  //Task_01
    {
        public string color;
        public double price;

        public string Color//(setter-only property)
        {
            set { color = value; }
        }

        public double Price { get; }//(read-only property)


    }    
}
