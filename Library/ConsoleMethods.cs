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
                Thread.Sleep(100);
                Console.Write(".");
            }
            Thread.Sleep(100);
            for (int i = 0; i < stringlength; i++)
            {
                Thread.Sleep(100);
                Console.Write(quit.Substring(i, 1));
            }
            Thread.Sleep(1000);
            Console.Clear();
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
                Thread.Sleep(50);
                Console.Write(line.Substring(i, 1));
            }
        }
    }
}
