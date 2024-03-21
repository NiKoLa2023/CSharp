

namespace Homework5a.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

       


        public Circle (string name, string color, double radius) : base()
        {
            Name = name;
            Color = color;                                          
           Radius = radius;
        }

        
        
        public override void getArea()
        { double Calcul1 = (Radius * Radius) * 3.14;
            Console.WriteLine($"The area of of the shape {Name} with color {Color} is {Calcul1} cm");
        }

        public override void Perimeter()
        {
            double Calcul2 = (Radius * 2 * 3.14);
            Console.WriteLine($"The area of of the shape {Name} with color {Color} is {Calcul2} cm");
        }
    }






}
