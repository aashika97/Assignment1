using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{


   public  class Car
    {
        // Properties
        private string brand;
        private int year;
        private float price;

        // Constructor
        public Car(string brand, int year, float price)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

        // Method to print car details
        public void PrintCarDetails()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Price: {price:C}"); // C format specifier for currency
        }
    }

}
