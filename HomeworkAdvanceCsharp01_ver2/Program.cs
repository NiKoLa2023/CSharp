//There should be a menu wadith three options:
//Play
//The user picks rock paper or scissors option
//The application picks rock paper scissors on random
//The user pick and the application pick are shown on the screen
//The application shows the winner
//The application saves 1 score to the user or the computer in the background
//When the user hits enter it returns to the main menu
//Stats
//It shows how many wins the user and how many wins the computer has
//It shows the percentage of the wins and losses of the user
//When the user hits enter it returns to the main menu
//Exit
//It closes the application


using System.ComponentModel.Design;
int playerGames = 0;
float player = 0;
int system = 0;
float percent = 0;
float lose = 0;
float percentLose = 0;
string adminWeapon = null;

try
{
    void checkWinner(string user, string admins)
    {
        if (user == admins)
        {

            playerGames++;
            Console.WriteLine("There is no winner");
        }
        else if (user == "Rock" && admins == "Scissor")
        {
            playerGames++;
            player++;
            Console.WriteLine("The player is winner");
        }
        else if (user == "Scissor" && admins == "Paper")
        {
            playerGames++;
            player++;
            Console.WriteLine("The player is winner");
        }
        else if (user == "Paper" && admins == "Rock")
        {
            playerGames++;
            player++;
            Console.WriteLine("The player is winner");
        }
        else
        {
            playerGames++;
            system++;
            lose++;
            Console.WriteLine("Admin is the winner");

        }
    }

    void checkAdmin(int adminUser)
    {

        if (adminUser >= 10 && adminUser <= 14)
        {
            adminWeapon = "Rock";
        }
        else if (adminUser >= 15 && adminUser <= 17)
        {
            adminWeapon = "Paper";
        }
        if (adminUser >= 18 && adminUser <= 20)
        {
            adminWeapon = "Scissor";

        }
    }



    while (true)
    {
        Console.WriteLine("Please choose from the menu");
        Console.WriteLine("1. Play, 2. Stats, 3. Exit");
        int input = int.Parse(Console.ReadLine());
        if (input == 1)
        {
            bool sucess;
            Console.WriteLine("1. Rock, 2. Paper, 3. Scissor");
            string user = Console.ReadLine();
            if (user == "Rock" || user == "Paper" || user == "Scissor")
            {
                int admin = new Random().Next(10, 20);
                checkAdmin(admin);
                checkWinner(user, adminWeapon);


                Console.WriteLine(player);
                Console.WriteLine(playerGames);
                bool backEnter;
                string backinput = (Console.ReadLine());
                if (backinput == " ") { backEnter = true; };
            }
            else
            {
                Console.WriteLine("Please enter from the given option");
                sucess = true;
            }


        }

        else if (input == 2)
        {
            if (player != 0 && playerGames != 0)
            {
                percent = (player / playerGames) * 100;
            }
            percentLose = (lose / playerGames) * 100;
            Console.WriteLine($"The player has {player} wins ");
            Console.WriteLine($"The system has {system} wins ");
            Console.WriteLine($"The percentage of wins of the plyer is {percent}% wins ");
            Console.WriteLine($"The percentage of lose of the plyer is {percentLose}% ");
            bool backEnter;
            string backinput = (Console.ReadLine());
            if (backinput == " ") { backEnter = true; };
        }
        else if (input == 3)
        {
            break;
        }
        else if (input > 3 && input < 1000000)
        {
            bool sucess1;
            Console.WriteLine("Please enter from the given option");
            sucess1 = true;
        };


    }
}
catch (DivideByZeroException e)
{
    Console.WriteLine("The zero can divide");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
