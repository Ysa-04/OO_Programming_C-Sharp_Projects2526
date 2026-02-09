namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
           
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
            Continue();
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

        public static void ExitProgram()
        {
            Console.Clear();
            string quit = "Quitting program";
            int stringlength = quit.Length;
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            Thread.Sleep(100);
            for (int i = 0; i < stringlength; i++)
            {
                Thread.Sleep(100);
                Console.Write(quit.Substring(i,1));
            }
            Thread.Sleep(1000);
        }

        public static void BackToMainMenu()
        {
            string quit = "Going back to main menu";
            int stringlength = quit.Length;
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            Thread.Sleep(100);
            for (int i = 0; i < stringlength; i++)
            {
                Thread.Sleep(100);
                Console.Write(quit.Substring(i,1));
            }
            Thread.Sleep(1000);
        }
        public static void Continue()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n");
            Console.WriteLine($"\t   Press <ENTER> to continue...");
            Console.ReadLine();
            Console.ResetColor();
        }

        
        public static void ClearCurrentConsoleLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

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
