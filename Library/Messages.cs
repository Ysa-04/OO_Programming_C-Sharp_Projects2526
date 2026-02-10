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
            Console.Write($"\t   [ERROR] ");
            Console.ResetColor();
            Console.Write(error);
        }
        public static void SuccesMessage(string succes)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.Write($"\t   [SUCCESS] ");
            Console.ResetColor();
            Console.Write(succes);        
        }
        public static void InfoMessage(string info)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.Write($"\t   [INFO] ");
            Console.ResetColor();
            Console.Write(info);
        }
        public static void Warning(string warning)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.Write($"\t   [WARNING] ");
            Console.ResetColor();
            Console.Write(warning);
        }
        

    }
}
