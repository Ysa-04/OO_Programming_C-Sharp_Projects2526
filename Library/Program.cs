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
                string title = "METHOD OVERVIEW";
                ConsoleMethods.CharByChar(title);
                Console.WriteLine();
                string border = "*-*-*-*-*-*-*-*";
                ConsoleMethods.CharByChar(border);
                Console.WriteLine("\n");
                Console.WriteLine("\t   0- EXIT");
                Thread.Sleep(50);
                Console.WriteLine("\t   1- MESSAGES OVERVIEW");
                Thread.Sleep(50);
                Console.WriteLine("\t   2- CONSOLE METHODS OVERVIEW");
                Thread.Sleep(50);
                Console.WriteLine("\t   3- INPUT METHODS OVERVIEW");
                Console.WriteLine();
                string message = "Make your choice: ";
                ConsoleMethods.CharByChar(message);
                string input = Console.ReadLine();
                int choice = Library.InputMethods.IntCheck(input);

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
                        Console.ReadLine();
                        break;
                }
            }

        }
        public static void MessagesOverview()
        {
            Console.Clear();
            ShowLogo();
            Console.WriteLine();
            Messages.InfoMessage("| Shows a neutral information message\n"); //for example: “Loading data…” or “Process started.”
            Messages.SuccesMessage("| Tells the user that something went well\n"); //for example: “Data saved successfully.”
            Messages.Warning("| Gives a warning about something that might be a problem\n"); //for example: “Some data may be lost.”
            Messages.ErrorMessage("| Shows an error message whenever something goes wrong"); //for example: “Invalid input, please try again.”
            ConsoleMethods.Continue();
        }
        public static void ConsoleMethodsOverview()
        {
            Console.Clear();
            ShowLogo();
            Console.WriteLine();
            Messages.InfoMessage("ExitProgram | Method to let user quit the program\n");
            Messages.InfoMessage("BackToMainMenu | Method to let user go back to main menu\n");
            Messages.InfoMessage("Continue | Method to continue the program whenever user pushes <ENTER>\n");
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
        /*
        public static void ClearCurrentConsoleLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        } */

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
