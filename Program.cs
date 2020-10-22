using System;
using System.Linq;

namespace Lab8GetToKnowClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueInput = true;
            while (continueInput == true)
            {
                string[] names = { "Brian", "Cameron", "Rachel", "Kevin", "Mary", "Samantha", "Jake", "Sam", "Bryce", "Dylan" };
                string[] favoriteFoods = { "Curry", "Pizza", "Ramen", "Spaghetti", "Muesli", "Fondue", "Kielbasa", "BiBimBop", "Garden Salad", "Katsu" };
                string[] favoriteSport = { "Association Football", "American Football", "Ice Hockey", "Basketball", "eSports", "Tennis", "Volleyball", "Field Hockey", "Handball", "Baseball" };
                string[] hometowns = { "Detroit", "Dearborn", "Lansing", "Grand Haven", "Allendale", "West Bloomfield", "Las Vegas", "Denver", "Los Angeles", "Boston" };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i + 1,-10}{names[i],-15}");
                }

                int students = int.Parse(GetUserInput($"Input a number corresponding to the student to learn a few bits of information about them."));

                if (students <= 1 && students <= 10 && String.IsNullOrEmpty(Convert.ToString(students)))
                {
                    Console.WriteLine($"Student #{students} : {names[students - 1]}\n");
                    Console.WriteLine("The three topics we have on students: hometown, favorite food and favorite sport.\n");
                    string topic = GetUserInput($"Which topic do you want to know about concerning {names[students - 1]}?");
                    topic = VerifyUserTopic(topic, $"Incorrect information. Please input either 'favorite food', 'favorite sport' or 'hometown'.");

                    if (topic == "favorite food")
                    {
                        Console.WriteLine($"Favorite food of {names[students - 1]}: {favoriteFoods[students - 1]}");
                    }
                    if (topic == "favorite sport")
                    {
                        Console.WriteLine($"Favorite sport of {names[students - 1]}: {favoriteSport[students - 1]}");
                    }
                    else if (topic == "hometown")
                    {
                        Console.WriteLine($"Hometown of {names[students - 1]}: {hometowns[students - 1]}");
                    }

                    Console.WriteLine("Continue? y/n");
                    string continueAsk = Console.ReadLine();
                    if (continueAsk == "y")
                    {
                        continueInput = true;
                    }
                    if (continueAsk == "n")
                    {
                        continueInput = false;
                    }
                }
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }

        public static int VerifyStudentInput(string message, int students)
        {
            while (students < 1 && students < 10)
            {
                Console.WriteLine(message);
                students = int.Parse(Console.ReadLine());
            }
            return students;
        }

        public static string VerifyUserTopic(string userTopic, string message)
        {
            while (userTopic != "hometown" && userTopic != "favorite food" && userTopic != "favorite sport")
            {
                Console.WriteLine(message);
                userTopic = Console.ReadLine();
            }
            return userTopic;
        }
    }
}
