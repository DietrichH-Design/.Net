using System;

//Namespace
namespace NumberGueser
{
    //Main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();//Run GetAppInfo function

            GreetUser();//Ask user name and greet
            

            while (true)
            {

                //Set correct number
                //int correctNumber = 7;

                //Create new random Object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");
                //While guess is not correct
                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //Make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red,"Please use an actual number");
                      
                        //Keep going
                        continue;
                    }
                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {                     
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number please try agian");
                    }
                }
                //Output success mesage
                
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                //ask to play again
                Console.WriteLine("Play again?[Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer=="Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        //get app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Gueser";
            string appVersion = "1.0.0";
            string appAuthor = "Dietrich Hein";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}:Version {1} by {2}", appName, appVersion, appAuthor);

            //reset app color
            Console.ResetColor();

        }
        //get user info
        static void GreetUser()
        {
            //ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets's play a game...", inputName);
        }

        //Print Color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user it is not a number
            Console.WriteLine(message);

            //reset app color
            Console.ResetColor();

        }
    }  
}