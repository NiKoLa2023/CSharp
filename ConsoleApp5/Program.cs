
int FirstNumber = 10;

int SecondNumber = 4;

int freeze = FirstNumber;

FirstNumber = SecondNumber;
SecondNumber = freeze;

Console.WriteLine(FirstNumber);
Console.WriteLine(SecondNumber);



