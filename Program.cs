using System;

// Namespace
namespace NumberGuesser
{
    // Main class
     class Program
    { 
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // run getappinfo function to get the user info

            GreetUser(); // ask for user name and greet

            while(true)
            {

            // Init (or initialize) correct number
            // int correctNumber = 7;
            // creat new random object 

            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            // Init guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // while guess is not correct
            while (guess != correctNumber)
            {
                // get the user input
                string input = Console.ReadLine();


                // Make sure it's a number 
                if (!int.TryParse(input, out guess))
                {
                        // Print error message 
                        PrintColorMessage(ConsoleColor.Red, "Please user an actual number!");

                    // Keep going
                    continue;
                }
                
                // cast to int and put in guess 
                // (Int32.Parse() changes a string number to int)
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber)
                {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number. Please try again!");

                    }
                }

                // Print success message 
                PrintColorMessage(ConsoleColor.Yellow, "Correct! You guessed it!");


                // ask to play again

                Console.WriteLine("Play again? [Y or N]");
                
                // Get answer 
                string answer = Console.ReadLine().ToUpper();
                
                if (answer == "Y")
                {
                    continue;
                } 
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app variables 
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mohammed Sibahi";

            // change text color (It changes all text on console)
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color (only the app text will remain Cyan)
            Console.ResetColor();
        }

        // Ask user's name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }
        // print color message 
        static void PrintColorMessage (ConsoleColor color, string message)
        {
            // change text color (It changes all text on console)
            Console.ForegroundColor = color;

            // Tell user it's not a number
            Console.WriteLine(message);

            // Reset text color (only the app text will remain Cyan)
            Console.ResetColor();
        }
    }
}
