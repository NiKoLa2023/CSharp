

namespace Homework5.Classess
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public void PrintEat()
        {
            Console.WriteLine($"The dog {Name} is now eating");
        }
        public void PrintPlay()
        {
            Console.WriteLine($"The dog {Name} is now playing");

        }
        public void ChaseTail()
        {
            Console.WriteLine($"The dog {Name} is now chasing its tail");

        }
    }
}

