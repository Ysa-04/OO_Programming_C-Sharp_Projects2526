using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ConsoleMethods
    {
        public static void ExitProgram()
        {
            Console.Clear();
            string quit = "Quitting program";
            int stringlength = quit.Length;
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(75);
                Console.Write(".");
            }
            Thread.Sleep(75);
            for (int i = 0; i < stringlength; i++)
            {
                Thread.Sleep(75);
                Console.Write(quit.Substring(i, 1));
            }
            Thread.Sleep(1000);
        }

        public static void BackToMainMenu()
        {
            string quit = "Going back to main menu";
            int stringlength = quit.Length;
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(75);
                Console.Write(".");
            }
            Thread.Sleep(75);
            for (int i = 0; i < stringlength; i++)
            {
                Thread.Sleep(75);
                Console.Write(quit.Substring(i, 1));
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

        public static void CharByChar(string line)
        {
            int length = line.Length;
            Console.Write("\t   ");
            for (int i = 0; i < length; i++)
            {
                Thread.Sleep(25);
                Console.Write(line.Substring(i, 1));
            }
        }

        public static void LoadScreen()
        {
            int percentage = 0;
            string loading = "\t   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒";
            string finished = "\t   ████████████████████";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\t   Loading Data...");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(
                    $"{finished.Substring(0, i) + loading.Substring(i, 20 - i)} {percentage}%"
                );
                Thread.Sleep(15 * (i + 1));
                if (i == 20)
                {
                    Thread.Sleep(892);
                }
                ClearCurrentConsoleLine();
                if (i % 7 == 0)
                {
                    percentage += 7;
                }
                else if (i % 3 == 0)
                {
                    percentage += 4;
                }
                else if (i == 19)
                {
                    percentage += 4;
                }
                else
                {
                    percentage += 5;
                }
            }
            Console.ResetColor();
            ClearCurrentConsoleLine();
            Messages.SuccesMessage("Loading Complete");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n\n{finished} 100%\n");
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
    }
}
