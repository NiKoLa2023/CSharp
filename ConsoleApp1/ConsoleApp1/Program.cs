
Console.WriteLine("Enter firstNumber");
string FirstNumber = Console.ReadLine();
Console.WriteLine("Enter secondNumber");
string SecondNumber = Console.ReadLine();
Console.WriteLine("Operator");
string operatorF = Console.ReadLine();

bool myfirstNumber = int.TryParse(FirstNumber, out int FirstConversion);
bool mysecondNumber = int.TryParse(SecondNumber, out int SecondConversion);
int result = FirstConversion + SecondConversion;
int secondResult = FirstConversion - SecondConversion;
int thirdrResult = FirstConversion * SecondConversion;
double fourthrResult = (double)FirstConversion / SecondConversion;

if (myfirstNumber && mysecondNumber)
{
    switch (operatorF)
    {
        case "+": Console.WriteLine("Result is " +  result); break;
        case "-": Console.WriteLine("Result is " + secondResult); break;
        case "*": Console.WriteLine("Result is " + thirdrResult); break;
        case "/": Console.WriteLine("Result is " + fourthrResult); break;
        default: Console.WriteLine("Not appropriate operator");break;

    }
}
else
{
    Console.WriteLine("Wrong input");
}





