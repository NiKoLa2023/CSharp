
int[] arrayOfInts = new int[6];

Console.WriteLine("Please enter first number");
bool firstNumberSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

if (firstNumberSuccess)
{
    arrayOfInts[0] = firstNumber;
}
else { Console.WriteLine("Please enter valid number"); }

Console.WriteLine("Please enter second number");

bool secondNumberSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);

if (secondNumberSuccess)
{
    arrayOfInts[1] = secondNumber;
}
else { Console.WriteLine("Please enter valid number"); }

Console.WriteLine("Please enter third number");

bool thirdNumberSuccess = int.TryParse(Console.ReadLine(), out int thirdNumber);

if (thirdNumberSuccess)
{
    arrayOfInts[2] = thirdNumber;
}
else { Console.WriteLine("Please enter valid number"); }

Console.WriteLine("Please enter fourth number");
bool fourthNumberSuccess = int.TryParse(Console.ReadLine(), out int fourthNumber);

if (fourthNumberSuccess)
{
    arrayOfInts[3] = fourthNumber;
}
else { Console.WriteLine("Please enter valid number"); }


Console.WriteLine("Please enter fifth number");
bool fifthNumberSuccess = int.TryParse(Console.ReadLine(), out int fifthNumber);

if (fifthNumberSuccess)
{
    arrayOfInts[4] = fifthNumber;
}
else { Console.WriteLine("Please enter valid number"); }


Console.WriteLine("Please enter sixth number");
bool sixthNumberSuccess = int.TryParse(Console.ReadLine(), out int sixthNumber);

if (sixthNumberSuccess)
{
    arrayOfInts[5] = sixthNumber;
}
else { Console.WriteLine("Please enter valid number"); }


if(firstNumberSuccess && secondNumberSuccess && thirdNumberSuccess && fourthNumberSuccess && fifthNumberSuccess && sixthNumberSuccess)
{ 
int temporary = 0;
for (int i = 0; i < arrayOfInts.Length; i++)
{
    if (arrayOfInts[i] % 2 ==0) {

        temporary = temporary + arrayOfInts[i];
        
    }
   
}
Console.WriteLine(temporary);
}

else { Console.WriteLine("Bad entry data"); }

