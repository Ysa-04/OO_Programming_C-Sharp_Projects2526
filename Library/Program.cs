using System.ComponentModel.Design;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static void Menu()
        {
            bool go = true; 
            while (go)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Library.Program.ShowLogo();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine("\t   |  Library Methods Overview |");
                Console.WriteLine("\t   *-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.WriteLine();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                string title = "MENU";
                string border = "*-*-*-*-*-*-*-*-*";
                ConsoleMethods.CharByChar(title);
                Console.WriteLine();
                ConsoleMethods.CharByChar(border);
                Console.WriteLine();
                Console.WriteLine("\t   0- EXIT");
                Thread.Sleep(50);
                Console.WriteLine("\t   1- MESSAGES OVERVIEW");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- CONSOLE METHODS OVERVIEW");
                Thread.Sleep(50);
                Console.WriteLine("\t   3- INPUT METHODS OVERVIEW");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                string message = "Make your choice: ";
                ConsoleMethods.CharByChar(message);
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                

                switch (choice)
                {
                    case 0:
                        ConsoleMethods.ExitProgram();
                        Console.WriteLine();
                        ConsoleMethods.BackToMainMenu();
                        go = false;
                        break;
                    case 1:
                        MessagesOverview();
                        break;
                    case 2:
                        ConsoleMethodsOverview();
                        break;
                    default:
                        Messages.ErrorMessage("Invalid input value");
                        break;
                }
            }

        }
        public static void MessagesOverview()
        {
            Console.Clear();
            ShowLogo();
            Console.WriteLine();
            Thread.Sleep(50);
            Messages.InfoMessage("| Shows a neutral information message\n"); //for example: “Loading data…” or “Process started.”
            Thread.Sleep(50);
            Messages.SuccesMessage("| Tells the user that something went well\n"); //for example: “Data saved successfully.”
            Thread.Sleep(50);
            Messages.Warning("| Gives a warning about something that might be a problem\n"); //for example: “Some data may be lost.”
            Thread.Sleep(50);
            Messages.ErrorMessage("| Shows an error message whenever something goes wrong"); //for example: “Invalid input, please try again.”
            ConsoleMethods.Continue();
        }
        public static void MethodsOverview(string method, string description)
        {
            Console.WriteLine();
            Thread.Sleep(50);
            Console.Write($"\t   {method} | {description}");
            Console.WriteLine();
        }

        public static void ConsoleMethodsOverview()
        {
            Console.Clear();
            ShowLogo();
            MethodsOverview("ExitProgram", "Method that lets the user quit or close the program safely.");
            MethodsOverview("BackToMainMenu", "Method that returns the user to the main menu from any section.");
            MethodsOverview("Continue", "Method that resumes program execution after user confirmation.");
            MethodsOverview("LoadScreen", "Method that displays a loading or transition screen between sections.");
            MethodsOverview("CharByChar", "Method that outputs text character by character, often for a typing effect.");
            MethodsOverview("ClearCurrentConsoleLine", "Method that clears the current line in the console output.");
            ConsoleMethods.Continue();
        }
    
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            string batLogo = @"
              /\                 /\
             / \'._   (\_/)   _.'/ \
            /_.''._'--('.')--'_.''._\
            | \_ / `;=/ "" \=;` \ _/ |
             \/ `\__|`\___/`|__/`  \/
                     \(/|\)/";

            Console.WriteLine(batLogo);
            Console.WriteLine();
            Console.ResetColor();
        }

        //Later op terugkomen

        // Question Y/N
        /*
        private bool firstError = true;
        public bool QuestionYN(string question, bool errorDisplay = true)
        {
            Console.Write($"{question} [Y/N] : ");
            string input = Console.ReadLine();
            bool returnValue = false;
            try
            {
                if (input.ToUpper() == "Y")
                {
                    returnValue = true;
                    RemoveErrorMessage(question + " [Y/N]", "Yes");
                }
                else if (input.ToUpper() == "N")
                {
                    returnValue = false;
                    RemoveErrorMessage(question + " [Y/N]", "No");
                }
                else
                {
                    returnValue = QuestionYN(question, errorDisplay);
                }
            }
            catch
            {
                if (errorDisplay)
                {
                    ErrorMessage(question);
                }
                returnValue = QuestionYN(question, errorDisplay);
            }
            firstError = true;
            return returnValue;
        }

        private void ErrorMessage(string errorMessage = "")
        {
            ClearCurrentConsoleLine();
            if (firstError == true)
            {
                ConsoleColor resetColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input Invalid");
                Console.ForegroundColor = resetColor;
            }
            firstError = false;
        }
        private void RemoveErrorMessage(string question, string value)
        {
            ClearCurrentConsoleLine();
            if (!firstError)
            {
                ClearCurrentConsoleLine();
            }
            Console.WriteLine($"{question} : {value}");
        } */
    }
}
