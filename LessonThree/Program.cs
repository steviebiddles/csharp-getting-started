using System;

namespace LessonThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Stephen";
            string greeting = $"Hello from lesson three {name}!";
            string level = "loud";

            if (level == "loud")
            {
                greeting = greeting.ToUpper();
            }
            else if (level == "quite")
            {
                greeting = greeting.ToLower();
            }

            Console.WriteLine(greeting);
            Console.ReadLine();
        }
    }
}
