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

            string[] coffeeClasses = new string[] { "Roasting 101", "Coffee Bean History", "Coffee Plant Botany", "Coffee Sales & Marketing", "Barista Training" };

            //Dictionaries of Each student and their respictive classes and grades
            // RC = Report Card
            // STUDENT 1
            Dictionary <string, double> studentOneRC = new Dictionary<string, double>();
            studentOneRC.Add("Roasting 101",100);
            studentOneRC.Add("Coffee Bean History", 100);
            studentOneRC.Add("Coffee Plant Botany", 80);
            studentOneRC.Add("Coffee Sales & Marketing", 100);
            studentOneRC.Add("Barista Training", 78.8);

            // STUDENT 2
            Dictionary<string, double> studentTwoRC = new Dictionary<string, double>();
            studentTwoRC.Add("Roasting 101", 67);
            studentTwoRC.Add("Coffee Bean History", 95);
            studentTwoRC.Add("Coffee Plant Botany", 100);
            studentTwoRC.Add("Coffee Sales & Marketing", 97);
            studentTwoRC.Add("Barista Training", 67);

            // STUDENT 3
            Dictionary<string, double> studentThreeRC = new Dictionary<string, double>();
            studentThreeRC.Add("Roasting 101", 92);
            studentThreeRC.Add("Coffee Bean History", 81);
            studentThreeRC.Add("Coffee Plant Botany", 85);
            studentThreeRC.Add("Coffee Sales & Marketing", 79);
            studentThreeRC.Add("Barista Training", 83);

            // STUDENT 4
            Dictionary<string, double> studentFourRC = new Dictionary<string, double>();
            studentFourRC.Add("Roasting 101", 82);
            studentFourRC.Add("Coffee Bean History", 100);
            studentFourRC.Add("Coffee Plant Botany", 65);
            studentFourRC.Add("Coffee Sales & Marketing", 77);
            studentFourRC.Add("Barista Training", 100);

            // STUDENT 5
            Dictionary<string, double> studentFiveRC = new Dictionary<string, double>();
            studentFiveRC.Add("Roasting 101", 100);
            studentFiveRC.Add("Coffee Bean History", 45);
            studentFiveRC.Add("Coffee Plant Botany", 62);
            studentFiveRC.Add("Coffee Sales & Marketing", 0);
            studentFiveRC.Add("Barista Training", 70);

            bool isValid = true;

            // Switch Statement for userSelect
            while (isValid)
            {
                PrintMenu();
                string userInput = Console.ReadLine().ToLower();

                //Validate user input
                while (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Looks like you left this blank. \nPlease Enter a valid input");
                    userInput = Console.ReadLine().ToLower();
                }
                switch (userInput)
                {
                    case "1":
                    case "see list of students":
                        Console.WriteLine("Students: \n");

                        // Display each student(key) in studentDict to the console
                        foreach(KeyValuePair<string, double> kvp in studentDict)
                        {
                            Console.WriteLine(kvp.Key);
                        }

                        // User should be presented with the option to look into the student's classes and grades for each class.
                        // If not, they may choose to exit to the main menu
                        Console.WriteLine("Type one of their names to see their classes or type exit to cancel:");
                        string nameInput = Console.ReadLine().ToLower();

                        //Validate nameInput
                        while (string.IsNullOrWhiteSpace(nameInput))
                        {
                            Console.WriteLine("Looks like you left this blank. \nPlease Enter a valid input");
                            nameInput = Console.ReadLine().ToLower();
                        }

                        bool studentMenuIsValid = true;
                        while (studentMenuIsValid)
                        {
                            switch (nameInput)
                            {
                                case "1":
                                case "michael scott":
                                    Console.WriteLine("--------------------------------------");
                                    Console.WriteLine("{0} : \n", nameInput.ToUpper());
                                    foreach(KeyValuePair<string,double> kvp in studentOneRC)
                                    {
                                        Console.WriteLine("Class : {0} - Grade : {1}",kvp.Key, kvp.Value);
                                        
                                    }
                                    LetterGradeCalc(studentOneRC);
                                    Console.WriteLine("--------------------------------------");
                                    break;

                                case "2":
                                case "dwight schrute":
                                    Console.WriteLine("--------------------------------------");
                                    Console.WriteLine("{0} : \n", nameInput.ToUpper());
                                    foreach (KeyValuePair<string, double> kvp in studentTwoRC)
                                    {
                                        Console.WriteLine("Class : {0} - Grade : {1}", kvp.Key, kvp.Value);

                                    }
                                    LetterGradeCalc(studentTwoRC);
                                    Console.WriteLine("--------------------------------------");
                                    break;

                                case "3":
                                case "jim halpert":
                                    Console.WriteLine("--------------------------------------");
                                    Console.WriteLine("{0} : \n",nameInput.ToUpper());
                                    foreach (KeyValuePair<string, double> kvp in studentThreeRC)
                                    {
                                        Console.WriteLine("Class : {0} - Grade : {1}", kvp.Key, kvp.Value);

                                    }
                                    LetterGradeCalc(studentThreeRC);
                                    Console.WriteLine("--------------------------------------");
                                    break;

                                case "4":
                                case "andy bernard":
                                    Console.WriteLine("--------------------------------------");
                                    Console.WriteLine("{0} : \n", nameInput.ToUpper());
                                    foreach (KeyValuePair<string, double> kvp in studentFourRC)
                                    {
                                        Console.WriteLine("Class : {0} - Grade : {1}", kvp.Key, kvp.Value);

                                    }
                                    LetterGradeCalc(studentFourRC);
                                    Console.WriteLine("--------------------------------------");
                                    break;

                                case "5":
                                case "toby flenderson":
                                    Console.WriteLine("--------------------------------------");
                                    Console.WriteLine("{0} : \n", nameInput.ToUpper());
                                    foreach (KeyValuePair<string, double> kvp in studentFiveRC)
                                    {
                                        Console.WriteLine("Class : {0} - Grade : {1}", kvp.Key, kvp.Value);

                                    }
                                    LetterGradeCalc(studentFiveRC);
                                    Console.WriteLine("--------------------------------------");
                                    break;
                                case "exit":
                                    studentMenuIsValid = false;
                                    break;

                                default:
                                    Console.WriteLine("No student of that name exists in this school.");
                                    Console.WriteLine("Type one of their names to see their classes or type exit to cancel:");
                                    nameInput = Console.ReadLine().ToLower();
                                    break;
                            }
                            studentMenuIsValid = false;
                        }

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

        // Method to calculate total grades and give appropriate final grade
        public static void LetterGradeCalc(Dictionary<string,double> studentGrades)
        {
            // Loop through each element in the dictionary, just want the values
            double sumUp = 0;
            foreach (KeyValuePair<string, double> kvp in studentGrades)
            {
                // Adds every value in the dictionary together
                sumUp += kvp.Value;
                
            }

            // Let calculate the average of all the summed up values
            double total = sumUp / 5;

            string letterGrade = null;

            // If statement for the range of each letterGrade
            if (total >= 89.5 && total <= 100)
            {
                letterGrade = "A";
            } 
            if (total >= 79.5 && total <= 89.4)
            {
                letterGrade = "B";
            }
            if (total >= 72.5 && total <= 79.4)
            {
                letterGrade = "C";
            }
            if (total >= 69.5 && total <= 72.4)
            {
                letterGrade = "D";
            }
            if (total >= 0 && total <= 69.4)
            {
                letterGrade = "F";
            }

            // Print both final numerical and letter grade to the console
            Console.WriteLine();
            Console.WriteLine("Numerical Grade - " + total);
            Console.WriteLine("Letter Grade - " + letterGrade);
        }

        // Calculate GPA
        public static void GPACalc()
        {

        }
    }
}
