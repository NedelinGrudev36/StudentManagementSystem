using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Menu
    {
        public void ShowMenu()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Students");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter age:");
                        int age = int.Parse(Console.ReadLine());

                        break;

                    case "2":
                        Console.WriteLine("Show Students");
                        break;

                    case "3":
                        running = false;
                        break;
                }
            }
        }
    }
}
