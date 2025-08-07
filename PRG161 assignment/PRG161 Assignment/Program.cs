using System;
using System.Collections.Generic;

namespace PRG161_Assignment //Compiled by Vusi Dennison
{
    internal class Program
    {
        static List<string> rentedBooks = new List<string>();

        static void ShowMenu()
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("Enter 1: Add books");
            Console.WriteLine("Enter 2: Track rentals");
            Console.WriteLine("Enter 3: Checkout");
            Console.WriteLine("Enter 4: Exit");
        }

        static void AddBooks() //Written by Imibongo Jama 604922
        {
            Console.WriteLine("\n--- Add Books ---");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();

            string gender;
            while (true)
            {
                Console.Write("Enter your gender (male/female): ");
                gender = Console.ReadLine().ToLower();
                if (gender == "male" || gender == "female")
                {
                    Console.WriteLine($"Gender entered: {gender}");
                    break;
                }
                Console.WriteLine("Invalid input. Please enter 'male' or 'female'.");
            }

            Console.Write("Enter email address: ");
            string email = Console.ReadLine();

            int phoneNumber;
            Console.Write("Enter phone number: ");
            while (!int.TryParse(Console.ReadLine(), out phoneNumber))
            {
                Console.WriteLine("Invalid number. Try again:");
            }

            // Book renting loop
            bool renting = true;
            while (renting)
            {
                Console.Write("Enter the book title to rent: ");
                string bookTitle = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(bookTitle))
                {
                    rentedBooks.Add(bookTitle);
                    Console.WriteLine($"Book '{bookTitle}' rented successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid title. Try again.");
                }

                Console.Write("Rent another book? (Y/N): ");
                if (Console.ReadLine().Trim().ToUpper() != "Y")
                    renting = false;
            }

            Console.WriteLine("\nBooks currently rented:");
            foreach (var book in rentedBooks)
            {
                Console.WriteLine($"- {book}");
            }
        }

        static void Tracks() //Written by Karabo Modise 604911
        {
            Console.WriteLine("\n--- Rental Tracking ---");
            if (rentedBooks.Count == 0)
            {
                Console.WriteLine("No books rented yet.");
                return;
            }

            Console.WriteLine("Books you have rented:");
            foreach (var book in rentedBooks)
            {
                Console.WriteLine($"- {book}");
            }
        }

        static void Checkout() // Written By Vusi Dennison 603604
        {
            Console.WriteLine("\n--- Checkout ---");
            if (rentedBooks.Count == 0)
            {
                Console.WriteLine("You have not rented any books.");
                return;
            }

            double total = 0;
            foreach (string book in rentedBooks)
            {
                Console.WriteLine($"Book: {book}");
                double price;
                Console.Write("Enter price: R");
                while (!double.TryParse(Console.ReadLine(), out price) || price < 0)
                {
                    Console.WriteLine("Invalid price. Enter a valid positive number.");
                }

                total += price;
            }

            Console.Write("Do you have a coupon? (Yes/No): ");
            string hasCoupon = Console.ReadLine().Trim().ToLower();
            if (hasCoupon == "yes")
            {
                Console.WriteLine("Applying 10% discount...");
                total *= 0.9;
            }

            Console.WriteLine($"Your total amount is: R{total:F2}");
            Console.WriteLine("Thank you for renting from us!");
        }

        enum Menu
        {
            Addbooks = 1,
            Tracks,
            Checkout,
            Leave
        }

        static void Main(string[] args)
        {
            Menu choice;
            do
            {
                ShowMenu();
                Console.Write("Choose an option (1-4): ");
                while (!Enum.TryParse(Console.ReadLine(), out choice) || !Enum.IsDefined(typeof(Menu), choice))
                {
                    Console.WriteLine("Invalid option. Try again.");
                }

                switch (choice)
                {
                    case Menu.Addbooks:
                        AddBooks();
                        break;
                    case Menu.Tracks:
                        Tracks();
                        break;
                    case Menu.Checkout:
                        Checkout();
                        break;
                    case Menu.Leave:
                        Console.WriteLine("Thank you for using the Magical Bookstore!");
                        return;
                }

            } while (true); //Khanyisile Maasiya 603532
        }
    }
}
