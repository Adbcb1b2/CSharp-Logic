using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace CSharpLogic
{
    class Program
    {
        /** This is the main class, the entry point to the program.
            This is where you can create instances of other classes, if they are public
            It attempts to retrieve the command line argument
            If there is one, it stores the command line argument and outputs it to the console
            If there isn't one, a message explaining this is outputed to the console
        **/
        static void Main(string[] args)
        {
            // Retrieving the ProjectName dynamically
            if (args.Length > 0)
            {
                string commandLineArgument = new(args[0]); // Store the command line argument
                Console.WriteLine(commandLineArgument);
            }
            else
            {
                Console.WriteLine("No command line argument provided.");
            }


            // Stateless method call
            //Authorisation.AuthoriseLoginCredentials();

            Authorisation.AuthoriseLoginCredentials2();
        }
    }

    class Authorisation
    {
        public static void AuthoriseLoginCredentials()
        {
            Console.WriteLine("Example 1 - AuthoriseLoginCredentials\n");

            // Define expected username and password
            string userPassword = "1234#";
            string userName = "Kim";

            // Get user input for username
            Console.WriteLine("Please enter your username");
            string? usernameInput = Console.ReadLine();

            // Check if username exists (is the same as the expected username using boolean logic)
            if (usernameInput == userName)
            {
                // If the user name does exist, ask for the password 
                Console.WriteLine("Please enter your password");
                string? passwordInput = Console.ReadLine();

                // Verify if the password is correct
                if (passwordInput == userPassword)
                {
                    Console.WriteLine("Password Correct!");
                }
                else
                {
                    Console.WriteLine("Password Incorrect!");
                }
            }
            // If the username doesn't exist
            else
            {
                Console.WriteLine("Username doesn't exist");
            }

        }
        public static void AuthoriseLoginCredentials2()
        {
            string firstPetName = "Henry";

            Console.WriteLine("Please enter the name of your first pet:");

            string? firstPetNameInput = Console.ReadLine();

            string result = (firstPetNameInput == firstPetName)
                ? "You have passed this step of the authorisation"
                : "You have entered the incorrect first pet name";

            Console.WriteLine(result);
        }
    }
    



    
}