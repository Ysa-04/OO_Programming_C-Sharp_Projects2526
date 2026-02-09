using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class InputCheck
    {
        public static int IntCheck(string input)
        {
            int choice;

            while (true)
            {
                if (int.TryParse(input, out choice))
                {
                    return choice;
                }
                Messages.ErrorMessage("Invalid input, try again");
                Console.Write("\n\n\t   ");
                input = Console.ReadLine();
            }
        }
    }
}
