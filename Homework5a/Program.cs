

using Homework5a.Models;

Shape Nikola = new Shape("Circleeeeee", "yellow", [10, 15]);
Nikola.PrintInfo();
Console.WriteLine(Nikola.Names);
Console.WriteLine(Nikola.Colors);
Nikola.Colors = "red";
Console.WriteLine(Nikola.Colors);


Circle Circle1 = new Circle("circle", "yellow", 10);
Circle1.getArea();
Circle1.Perimeter();

Rectangle Rectangle1 = new Rectangle("rectangle", "blue", 10, 15);
Rectangle1.getArea();
Rectangle1.Perimeter();