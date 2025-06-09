using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
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

            //Authorisation.AuthoriseLoginCredentials2();
            //PermissionLevel.PermissionLevelCheck();
            //VariableScopeExample.VariableScopeCheck();
            //VariableScopeExample2.VariableScopeCheck2();
            //SwitchCaseExample.SwitchCaseEmployeeLevelCheck();
            WhileAndDoWhileExamples.Example1();
            WhileAndDoWhileExamples.Example2();
            WhileAndDoWhileExamples.Example3();

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

    class PermissionLevel
    {
        public static void PermissionLevelCheck()
        {
            string permission = "Admin|Manager";
            int level = 56;

            if (permission.Contains("Admin"))
            {
                Console.Write((level > 55) ? "Welcome, Super Admin." : "Welcome Admin.");
            }
            else if (permission.Contains("Manager"))
            {
                Console.WriteLine((level >= 20) ? "Contact Admin for Access" : "You don't have sufficient privilidges.");
            }
            else
            {
                Console.WriteLine("You don't have sufficient privilidges");
            }


        }
    }

    class VariableScopeExample
    {

        public static void VariableScopeCheck()
        {
            bool flag = true;
            if (flag)
            {
                int value = 10;
                Console.WriteLine($"Inside the code block: {value}"); // Variable will only be accessible within the code block
            }
            // Wouldn't be able to do this as it is outside the codeblock: Console.WriteLine($"Outside the code block: {value}");

        }
    }

    class VariableScopeExample2
    {
        public static void VariableScopeCheck2()
        {
            bool flag = true;
            int value = 0;

            if (flag)
            {
                value = 10;
                Console.WriteLine($"Inside the codeblock value: {value}");
            }

            // This should print outside the code block, with the value it was assigned inside the code block
            Console.WriteLine($"Outside the codeblock: {value}");

            // Did you know, you don't need curly braces if the block after a conditional statement is only 1 line long!
            string name = "Kim";

            if (name == "Steve")
                Console.WriteLine("We found Steve!");
            else if (name == "Kim")
                Console.WriteLine("We found Kim"!);
            else
                Console.WriteLine("We found Bob");
        }
    }

    class SwitchCaseExample
    {
        public static void SwitchCaseEmployeeLevelCheck()
        {
            int employeeLevel = 200;
            string title;

            // Switch statement
            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                case 500:
                    title = "Associate";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine(title);
        }
    }

}

class WhileAndDoWhileExamples
{
    public static void Example1()
    {

        // Generate a random object
        Random random = new Random();

        int randomNumber = 0;
        // This is a do-while loop - guranteed to run at least once
        do
        {
            // This block executes in a loop until the condition is met
            randomNumber = random.Next(1, 11); // Generate a random number 1-10
            Console.WriteLine("Current Number: " + randomNumber);
        } while (randomNumber != 7);

        Console.WriteLine("Number: " + randomNumber + " The loop is over"); // This wll only excute once the loop has exited, i.e the random number is 7
    }

    public static void Example2()
    {
        int number = 4;

        // This is a while loop, not guranted to run 
        while (number != 4)
        {
            Console.WriteLine("Your number doesn't equal 4!");
        }

        Console.WriteLine("Your number equals 4");
    }

    public static void Example3()
    {
        Random random = new Random();
        int current = 1;

        do
        {
            current = random.Next(1, 11);

            if (current >= 8) continue;

            Console.WriteLine(current); // This will only print when the number is less than 8 and not 7
        } while (current != 7);
    }


}