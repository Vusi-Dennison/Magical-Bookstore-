using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG161_Assignment
{
    internal class Program
    {
        static void Showmenu()

        {
            Console.WriteLine("Enter 1: to go to Addbooks");
            Console.WriteLine("Enter 2: to go to Tracks");
            Console.WriteLine("Enter 3: to go to Checkout");
            Console.WriteLine("Enter 4: to go to Leave");

        }
        static void Addbooks()
        {
            string name, surname, number, Email;

          
          
            int num = 0;
            
            int ID;
            string booktitle;
            double rentalprice;



            Console.WriteLine("Write name here");
            name = Console.ReadLine();
            Console.WriteLine("enter surname here");
            surname = Console.ReadLine();
            Console.WriteLine("Gender");
            string gender = Console.ReadLine();

            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Enter your gender (male/female): ");
                gender = Console.ReadLine();

                if (gender == "male" || gender == "female")
                {
                    isValid = true;
                    Console.WriteLine("You entered a valid gender: gender");
                }
                else

                    Console.WriteLine("Invalid input. Please enter 'Male' or 'Female'.");

            }
            Console.WriteLine("enter Email Address");
            Email = Console.ReadLine();
            Console.WriteLine("enter phone number here");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Book Title");
            booktitle = Console.ReadLine();
            Console.WriteLine("Book rental price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Would you like to add another one Y/N?");
            string stop;
            stop = Console.ReadLine().ToUpper();
            
            bool agree = true;
            if (stop == "N")
            {

                agree = true;
                Console.WriteLine("it is what it is good bye");

            }
            else
            {

                agree = false;

            }
            Console.WriteLine("Would you like to leave the program? if so click 4, if not type type the number of the next menu you want to vist");









        }
        static void Tracks()
        {








        }
        static void Checkout()
        {








        }



        enum menu
        {
            Addbooks = 1,
            Tracks,
            checkout,
            Leave,
        }

        static void Main(string[] args)
        {
            menu choice;
            do
            {
                Showmenu();
                Console.WriteLine("Choose in the options above");
                choice = (menu)int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case menu.Addbooks:
                        Addbooks();
                        break;
                    case menu.Tracks:
                        Tracks();
                        break;
                    case menu.checkout:
                        Checkout();
                        break;
                    case menu.Leave:
                    default:
                        Environment.Exit(4);
                        break;
                }


            }
            while (true);

        }
    }
}
