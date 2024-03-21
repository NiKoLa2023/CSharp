
namespace Homework5a.Models
{
    internal class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }



        public Rectangle(string name, string color, int[] coordinates) : base(name, color, coordinates)
        {
            Move();
        }
        public Rectangle(string name, string color, double sidea, double sideb) : base()
        {
            Name = name;
            Color = color;
            SideA = sidea;
            SideB = sideb;
        }


        public override void getArea()
        {
            double Calcul1 = (SideA*SideB);
            Console.WriteLine($"The area of of the shape {Name} with color {Color} is {Calcul1} cm");
        }

        public override void Perimeter()
        {
            double Calcul2 = 2*(SideA+SideB);
            Console.WriteLine($"The area of of the shape {Name} with color {Color} is {Calcul2} cm");
        }
        protected override void Move()
        {
            Coordinates[0] = Coordinates[0] + 5;
            Coordinates[1] = Coordinates[1] + 5;
        }
        public override void PrintInfo()
        {

            Console.WriteLine($"The updated coordinate position for X is {Coordinates[0]} and for Y is {Coordinates[1]}");
        }
    }
}
