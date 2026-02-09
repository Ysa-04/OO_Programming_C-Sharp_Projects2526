using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Messages
    {
        public static void ErrorMessage(string error)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine($"\t   ERROR | {error.ToUpper()}");
            Console.ResetColor();
        }
        public static void SuccesMessage(string succes)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine($"\t   SUCCESS | {succes.ToUpper()}");
            Console.ResetColor();
        }
        public static void InfoMessage(string info)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.WriteLine($"\t   INFO | {info}");
            Console.ResetColor();
        }
        public static void Warning(string warning)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine($"\t   WARNING | {warning}");
            Console.ResetColor();
        }
        

    }
}
