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
            string name;
            string name2;
            int restaurantMenu = 0;

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("This program will demonstrate a case statement and a while loop");
            Console.WriteLine("*******************************************************************************");
            Console.Write("Enter your first name: ");
            name = Console.ReadLine();
            Console.Write("Enter your last name: ");
            name2 = Console.ReadLine();
            while(restaurantMenu != 5)
            {
                Console.WriteLine("*******************************************************************************");
                Console.WriteLine("What would you like to eat on the menu?");
                Console.WriteLine("*******************************************************************************");
                Console.WriteLine("1) Pizza");
                Console.WriteLine("2) Burger");
                Console.WriteLine("3) Hot Dog");
                Console.WriteLine("4) Ice Cream");
                Console.WriteLine("5) Nothing");
                Console.WriteLine();
                Console.Write("{0} {1}, please make your selection (1 to 5): ", name, name2);
                prompt = Console.ReadLine();
                restaurantMenu = Convert.ToInt32(prompt);
                switch (restaurantMenu)
                {
                    case 1:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("Do you want to order pizza?");
                        Console.WriteLine("What else would you like to order on the menu {0}?", name);
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("Press any key to select the next choice on the menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("Do you want to order burger(s)?");
                        Console.WriteLine("What else would you like to order on the menu {0}?", name);
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("Press any key to select the next choice on the menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("Do you want to order hot dog(s)?");
                        Console.WriteLine("What else would you like to order on the menu {0}?", name);
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("Press any key to select the next choice on the menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("Do you want to order ice cream?");
                        Console.WriteLine("What else would you like to order on the menu {0}?", name);
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("Press any key to select the next choice on the menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("You don't want to order anything?");
                        Console.WriteLine("Thank you for ordering and have a nice day {0}! :)", name);
                        break;
                    default:
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("ERROR - Invalid choice or selction, please try again {0}!", name);
                        Console.WriteLine("*******************************************************************************");
                        Console.WriteLine("Press any key to select the next choice on the menu...");
                        Console.ReadKey();
                        Console.Clear();
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
