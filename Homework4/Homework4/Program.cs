using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;


//Task 1//

using System.Runtime.ExceptionServices;

Console.WriteLine("PLease enter simple string");
string input = Console.ReadLine();


int lenghtInput = input.Length - 5;

string reducedNikola = input.Substring(lenghtInput, 5); //
Console.WriteLine(reducedNikola);



//Task 2 Take a sentence as input and print its words.//
Console.WriteLine("PLease enter sentence");
string inputMessage = Console.ReadLine();


string[] words = inputMessage.Split(" ");



foreach (string word in words)
{
    Console.WriteLine(word);
}


//Task 3 Create a function that takes a number as input. This method should return the sum of the digits in the number//


Console.WriteLine("PLease enter number");
bool sucees = int.TryParse(Console.ReadLine(), out int inputThird);

if (sucees && inputThird>0) 
{ Console.WriteLine(Printinfo(inputThird));}

else { Console.WriteLine("Please eneter valid number"); }

    int Printinfo(int number)
    {
        int sum = 0;
        while (inputThird > 0)
        {
            int R = inputThird % 10;
            sum += R;
            inputThird = inputThird / 10;
        }

        return sum;

    }


    
