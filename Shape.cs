using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public class Shape
    {
        // Virtual method to calculate the area
        public virtual float CalculateArea()
        {
            return 0;
        }
    }

    class Circle : Shape
    {
        // Properties
        private float radius;

        // Constructor
        public Circle(float radius)
        {
            this.radius = radius;
        }

        // Override CalculateArea method to calculate the area of a circle
        public override float CalculateArea()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }
    }
}
