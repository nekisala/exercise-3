using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsonsaKisala_Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Welcome statement
            Console.Clear();
            Console.WriteLine("Welcome to Coffee High \nThe Place to learn anything and everything about coffee! \n");

            // Student Dictionary (names, grades)
            Dictionary<string, double> studentDict = new Dictionary<string, double>();

            studentDict.Add("Michael Scott", 89);
            studentDict.Add("Dwight Schrute", 99.99);
            studentDict.Add("Jim Halpert", 100);
            studentDict.Add("Andy Bernard", 74);
            studentDict.Add("Toby Flenderson", 40);

            bool isValid = true;
            // Switch Statement for userSelect
            while (isValid)
            {
                PrintMenu();
                string userSelect = Console.ReadLine().ToLower();
                switch (userSelect)
                {
                    case "1":
                    case "see list of students":
                        Console.WriteLine("Students: \n");

                        // Display each student(key) in studentDict to the console
                        foreach(KeyValuePair<string, double> kvp in studentDict)
                        {
                            Console.WriteLine(kvp.Key);
                        }

                        //Console.WriteLine("Type one of their names to see their classes:");
                        //string nameInput = Console.ReadLine().ToLower();
                        //bool studentMenuIsValid = true;
                        //while (studentMenuIsValid)
                        //{
                        //    switch (nameInput)
                        //    {
                        //        case "michael scott":
                        //            break;
                        //        case "dwight schrute":
                        //            break;
                        //        case "jim halpert":
                        //            break;
                        //        case "andy bernard":
                        //            break;
                        //        case "toby flenderson":
                        //            break;
                        //    }
                        //}

                        break;
                    case "2":
                    case "see student gpas":
                        Console.WriteLine("GPA: \n");

                        //Display the list of students and their respective gpas
                        foreach (KeyValuePair<string, double> kvp in studentDict)
                        {
                            Console.WriteLine("{0} - {1}", kvp.Key,kvp.Value);
                        }
                        break;
                    case "3":
                    case "edit student grades":
                        Console.WriteLine("Edit: \n");
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
        public static void PrintMenu()
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
