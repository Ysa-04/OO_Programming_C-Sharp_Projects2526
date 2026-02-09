namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
        }
        public static void MessagesOverview()
        {
            Console.Clear();
            ShowLogo();
            Console.WriteLine();
            Messages.InfoMessage("Shows a neutral information message, for example: “Loading data…” or “Process started.”");
            Messages.SuccesMessage("Tells the user that something went well, for example: “Data saved successfully.”");
            Messages.Warning("Gives a warning about something that might be a problem, for example: “Some data may be lost.”");
            Messages.ErrorMessage("Shows an error message whenever something goes wrong, for example: “Invalid input, please try again.”");
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
    }
}
