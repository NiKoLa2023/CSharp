
using Homework5.Classess;

Dog dogName = new Dog();

while (true)
{
    Console.WriteLine("Please enter name");
    dogName.Name = Console.ReadLine();
    Console.WriteLine("Please choose the message 1.PrintEat /n 2.PrintPlay /n 3.ChaseTail");
    int input = int.Parse(Console.ReadLine());
    if(input == 1)
    {
        dogName.PrintEat();
    }
    else if(input == 2) {
        dogName.PrintPlay();
    }
    else if (input == 3)
    {
        dogName.ChaseTail();
    }
    else { Console.WriteLine("Please chooese from 1 to 3"); }
}