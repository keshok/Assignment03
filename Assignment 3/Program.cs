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
            int restaurantMenu = 0;

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("This program will demonstrate a case statement and a while loop");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("What would you like to eat on the menu?");
            while(restaurantMenu != 5)
            {
                Console.WriteLine("*******************************************************************************");
                Console.WriteLine("1) Pizza");
                Console.WriteLine("2) Burger");
                Console.WriteLine("3) Hot Dog");
                Console.WriteLine("4) Ice Cream");
                Console.WriteLine("5) Nothing");
                Console.WriteLine();
                Console.Write("Please make your selection (1 to 5): ");
                prompt = Console.ReadLine();
                restaurantMenu = Convert.ToInt32(prompt);
                switch (restaurantMenu)
                {
                    case 1:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("You want to order pizza?");
                        Console.WriteLine("What else would you like on the menu?");
                        break;
                    case 2:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("You want to order burger?");
                        Console.WriteLine("What else would you like on the menu?");
                        break;
                    case 3:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("You want to order hot dog?");
                        Console.WriteLine("What else would you like on the menu?");
                        break;
                    case 4:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("You want to order ice cream?");
                        Console.WriteLine("What else would you like on the menu?");
                        break;
                    case 5:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("You don't want anything?");
                        Console.WriteLine("Thank you for ordering and have a nice day! :)");
                        break;
                    default:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("ERROR - Invalid choice or selction, please try again!");
                        break;
                }
            }
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Press any key to exit...");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.ReadKey();
        }
    }
}
