using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInputColumn();
            UserInput();
        }

        static void Header()
        {
            Console.Clear();
            Console.Write("Welcome to our C# class. Would you like to add a student or learn more about a current student? (add or more)  ");
        }

        public static void UserInput()
        {
            List<object[]> dataGrid = new List<object[]>();
            object[] studentIndex = new object[8] { "first name", "last name", "nickname", "height", "age", "gender", "glasses", "home state" };
            dataGrid.Add(studentIndex);
            object[] student1 = new object[8] { "Brian", "Wahler", "N/A", "6ft 4in", 28, 'M', true, "MI" };
            dataGrid.Add(student1);
            object[] student2 = new object[8] { "Tyler", "Carron", "N/A", "6ft 4in", 18, 'M', false, "MI" };
            dataGrid.Add(student2);
            object[] student3 = new object[8] { "Damacious", "White", "Mace", "6ft", 27, 'M', false, "MI" };
            dataGrid.Add(student3);
            object[] student4 = new object[8] { "David", "Hess", "N/A", "5ft 11in", 23, 'M', true, "MI" };
            dataGrid.Add(student4);
            object[] student5 = new object[8] { "Clayton", "Cox", "N/A", "6ft", 32, 'M', false, "OH" };
            dataGrid.Add(student5);
            object[] student6 = new object[8] { "Mauricio", "Reyna", "N/A", "5ft 7in", 19, 'M', true, "MI" };
            dataGrid.Add(student6);
            object[] student7 = new object[8] { "Jacky", "Chan", "N/A", "5ft 11in", 24, 'M', false, "MI" };
            dataGrid.Add(student7);
            object[] student8 = new object[8] { "Rudy", "Gall", "N/A", "5ft 8in", 20, 'M', false, "MI" };
            dataGrid.Add(student8);
            object[] student9 = new object[8] { "Evan", "Simon", "N/A", "6ft", 28, 'M', false, "OH" };
            dataGrid.Add(student9);
            object[] student10 = new object[8] { "Camille", "Pouncy", "N/A", "5ft 2.75in", 26, 'F', false, "MI" };
            dataGrid.Add(student10);
            object[] student11 = new object[8] { "Steven", "Webster", "Steve", "6ft 5in", 28, 'M', true, "OH" };
            dataGrid.Add(student11);
            object[] student12 = new object[8] { "Sean", "Robinson", "Sean'O", "5ft 11in", 31, 'M', false, "MI" };
            dataGrid.Add(student12);
            object[] student13 = new object[8] { "Heather", "Harper", "N/A", "5ft 5in", 43, 'F', false, "MI" };
            dataGrid.Add(student13);
            object[] student14 = new object[8] { "Anthony", "Todek", "Tony", "6ft", 27, 'M', true, "MI" };
            dataGrid.Add(student14);
            object[] student15 = new object[8] { "Jonathan", "Leech", "N/A", "5ft 6.5in", 27, 'M', false, "MI" };
            dataGrid.Add(student15);
            object[] student16 = new object[8] { "Nicholas", "Landan", "N/A", "5ft 8in", 23, 'M', false, "MI" };
            dataGrid.Add(student16);
            object[] student17 = new object[8] { "Levi", "Sims", "N/A", "5ft 8in", 21, 'M', false, "MI" };
            dataGrid.Add(student17);
            object[] student18 = new object[8] { "Andrea", "Dabrowski", "N/A", "5ft 5.5in", 24, 'F', false, "MI" };
            dataGrid.Add(student18);
            object[] student19 = new object[8] { "Kathleen", "Harrell", "Katie", "5ft 8in", 36, 'F', true, "MI" };
            dataGrid.Add(student19);

            Regex numeric = new Regex("[0-9]{ 1,19}");
            bool retry = true;
            while (retry)
            {
                Header();
                string answer = Console.ReadLine().ToLower();
                if (answer.Equals("add"))
                {
                    Console.Write("\nFirst Name:  ");
                    string firstName = Console.ReadLine().Trim();
                    Console.Write("\nLast Name:  ");
                    string lastName = Console.ReadLine().Trim();
                    Console.Write("\nNickname:  ");
                    string nickname = Console.ReadLine().Trim();
                    Console.Write("Height (xft yin):  ");
                    string height = Console.ReadLine().Trim();
                    Console.Write("Age:  ");
                    int.TryParse(Console.ReadLine().Trim(), out int age);
                    Console.WriteLine("Gender (M/F):  ");
                    char.TryParse(Console.ReadLine().Trim(), out char gender);
                    Console.WriteLine("Glasses (true/false):  ");
                    bool.TryParse(Console.ReadLine().Trim().ToLower(), out bool glasses);
                    Console.WriteLine("Home State (XX):  ");
                    string homeState = Console.ReadLine().Trim().ToUpper();

                    object[] student = new object[8] { firstName, lastName, nickname, height, age, gender, glasses, homeState };
                    dataGrid.Add(student);

                }
                else if (answer.Equals("more"))
                {
                    Console.WriteLine($"Which student would you like to learn more about? (enter a number 1-{dataGrid.Count - 1}):  ");
                    int.TryParse(Console.ReadLine(), out int index);
                    while (retry)
                    {
                        if (index > 0 && index < dataGrid.Count)
                        {
                            while (retry)
                            {
                                var options = dataGrid[0].Skip(2).Take(6).ToArray();
                                string valueKey = string.Join(", ", options);
                                string selection = null;
                                int request = 0;
                                Regex valKey = new Regex(valueKey);
                            
                                while (retry)
                                {
                                    Console.WriteLine($"\nStudent {index} is {dataGrid[index][0]} {dataGrid[index][1]}. What would you like to know about {dataGrid[index][0]}?\n({valueKey}):  ");
                                    selection = Console.ReadLine().ToLower();
                                    bool valid = false;
                                    foreach (string value in dataGrid[0])
                                    {
                                        for (int i = 0; i < 8; i++)
                                        {                                        
                                            string select = Convert.ToString(dataGrid[0][i]);
                                            if (select == selection)
                                            {
                                                request = i;
                                                valid = true;
                                            }
                                        }
                                    }
                                    if (valid)
                                    {
                                        Console.WriteLine($"{selection}: {dataGrid[index][request]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Entry...");
                                    }
                                    Console.WriteLine($"Find out more about {dataGrid[index][0]}? (y/n)  ");
                                    retry = Retry();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nThat student does not exist. Please try again. (enter a number 1-19):  ");
                            int.TryParse(Console.ReadLine(), out index);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Entry...");
                }
                Console.WriteLine("\nAdd another student or check student information? (y/n)  ");
                retry = Retry();
            }
            Exit();
        }

        static bool Retry()
        {
            bool valid = false;
            bool retry = true;
            while (!valid)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Y)
                {
                    valid = true;
                }
                else if (key == ConsoleKey.N)
                {
                    valid = true;
                    retry = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input, Please Try Again...");
                }
            }
            return retry;
        }

        static void Exit()
        {
            Console.WriteLine("\nGoodbye! Press ESCAPE to exit");
            bool exit = false;
            while (!exit)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Escape)
                {
                    exit = true;
                }
            }
        }
    }
}
