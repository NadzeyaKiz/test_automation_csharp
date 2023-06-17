using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP2
{
    public class Table
    {
        public string Name;
        public int Quantity;
        public double Price = 99.99;// Default value for the Price field (Task_13)
        public string Brand;
        public bool IsAvailable;
        public void PrintAvailability()
        {
            if (Quantity > 0)
            {
                Console.WriteLine("Table {0} is avalible.", Name);
            }
            else
            {
                Console.WriteLine("Product {0} is temporarily out of stock.", Name);
            }
        }
        //Class constructor Task_6
        public Table(string name, int quantity, double price, string brand, bool isAvailable)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Brand = brand;
            IsAvailable = isAvailable;
        }

        // Empty constructor (Task_7)
        public Table()
        {
            // No explicit field initialization required, as they will be set to their default values
            //for the corresponding data types: string - null, int - 0, double - 0.0, bool - false
        }
        // Constructor initializing 2 fields (Task_08)
        public Table(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        // Method with private modifier (Task_11)
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }

        // Method with internal modifier (Task_11)
        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method");
        }
    }

    }
