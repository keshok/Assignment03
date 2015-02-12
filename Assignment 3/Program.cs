using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt;
            int restaurantMenu;
            bool choice;

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("What would you like to eat on the menu?");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("1) Pizza");
            Console.WriteLine("2) Burger");
            Console.WriteLine("3) Hot Dog");
            Console.WriteLine("4) Ice Cream");
            Console.WriteLine("5) Exit");
            Console.WriteLine();
            Console.Write("Please make your selection (1 to 5): ");
            prompt = Console.ReadLine();
            restaurantMenu = Convert.ToInt32(prompt);

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("*******************************************************************************");
            Console.ReadKey();
        }
    }
}
