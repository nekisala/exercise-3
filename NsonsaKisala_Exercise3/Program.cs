using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsonsaKisala_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome statement
            Console.Clear();
            Console.WriteLine("Welcome to Coffee High \nThe Place to learn anything and everything about coffee! \n");
            

           
            bool isValid = true;
            // Switch Statement for userSelect
            while (isValid)
            {
                Menu();
                string userSelect = Console.ReadLine().ToLower();
                switch (userSelect)
                {
                    case "1":
                    case "see list of students":
                        Console.WriteLine("1 works");
                        break;
                    case "2":
                    case "see student gpas":
                        Console.WriteLine("2 works");
                        break;
                    case "3":
                    case "edit student grades":
                        Console.WriteLine("3 works");
                        break;
                    case "4":
                    case "exit":
                        isValid = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input"); 
                        return;
                            
                }
            }

        }
        // Create Menu
        public static void Menu()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1 - See List of students \n" +
                "2 - See Student GPAs \n" +
                "3 - Edit Student Grades \n" +
                "4 - Exit");
            Console.WriteLine("--------------------------------------");
        }
    }
}
