Console.WriteLine("Enter firstNumber");
string firstNumberInput = Console.ReadLine();
Console.WriteLine("Enter secondNumber");
string secondNumberInput = Console.ReadLine();
Console.WriteLine("Enter thirdNumber");
string thirdNumberInput = Console.ReadLine();
Console.WriteLine("Enter fourthNumber");
string fourthNumberInput = Console.ReadLine();

bool myfirstInputResult = int.TryParse(firstNumberInput, out int firstConversionInput);
bool mysecondInputResult = int.TryParse(secondNumberInput, out int secondConversionInput);
bool mythirdInputResult = int.TryParse(thirdNumberInput, out int thirdConversionInput);
bool myfourthInputResult = int.TryParse(fourthNumberInput, out int fourthConversionInput);
double finalResult = (double)(firstConversionInput + secondConversionInput + thirdConversionInput + fourthConversionInput) / 4;

if (myfirstInputResult && mysecondInputResult && mythirdInputResult && myfourthInputResult)
{
    Console.WriteLine("The average of " + firstConversionInput + "," + secondConversionInput + "," + thirdConversionInput + "," + fourthConversionInput + " is:" + finalResult);
}
else
{
    Console.WriteLine("PLease enter valid number");
}

