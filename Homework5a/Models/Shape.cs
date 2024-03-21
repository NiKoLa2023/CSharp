

using System.Security.Cryptography;

namespace Homework5a.Models
{
    public class Shape
    {
        public string Name;

        public string Color;

        public int[] Coordinates { get; set; }

        public Shape()
        {
        
        }

        public Shape(string name, string color, int[] coordinates)
        {
            Names = name;
            Colors = color;
            Coordinates = coordinates;
            Move();


        }
        public virtual void getArea()
        {
            Console.WriteLine("There is no special implementation for area");
        }

        public virtual void Perimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }
        protected virtual void Move()
        {
            Coordinates[0] = Coordinates[0] + 5;
            Coordinates[1] = Coordinates[1] + 5;
        }
        public virtual void PrintInfo()
        {
            
            Console.WriteLine($"The updated coordinate position for X is {Coordinates[0]} and for Y is {Coordinates[1]}");
        }

        public string Names
        {
            get { return Name; }
            set
            {
                if (value.Length > 3 && value.Length<7)
                {
                    Name = value;
                }
                else { Name = "NA"; }
            }
        }
        public string Colors
        {
            get { return Color; }
            set
            {
                if (value == "red" || value == "green" || value == "blue")
                {
                    Color = value;
                }
                else { Color = "NA"; }
            }
        }
    }
}
