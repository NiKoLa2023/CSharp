Console.WriteLine("Please enter numberGroup");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);
if (firstSuccess && (firstNumber == 1 || firstNumber == 2))
{
    firstSuccess = true;
}
else { firstSuccess = false; }


string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Nikola", "Angelina", "MAxim ", "Luka", "Gogo" };


if (firstSuccess)
{
    if (firstNumber == 1)
    {
        Console.WriteLine("The Students in G1 are:");
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }
    }
    if (firstNumber == 2)
        {
        Console.WriteLine("The Students in G2 are:");
        for (int i = 0; i < studentsG2.Length; i++)
            {
                Console.WriteLine(studentsG2[i]);
            }
        }
    }

else { Console.WriteLine("Please enter 1 or 2"); }
