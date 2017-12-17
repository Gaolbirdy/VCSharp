using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string aFriend = "Bill";
            Console.WriteLine(aFriend);
            aFriend = "Maia";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");

            string firstFriend = "Maira";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            string message = "       Hello World!            ";
            Console.WriteLine($"{message}");

            string trimmedMessage = message.TrimStart();
            Console.WriteLine($"{trimmedMessage}");

            trimmedMessage = message.TrimEnd();
            Console.WriteLine($"{trimmedMessage}");

            trimmedMessage = message.Trim();
            Console.WriteLine($"{trimmedMessage}");

            Console.WriteLine($"{message}");

            message = "Hello World!";
            Console.WriteLine(message);
            message = message.Replace("Hello", "Greetings");
            Console.WriteLine(message);

            message = "Hello World!";
            Console.WriteLine(message);
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());

            message = "You say goodbye, and I say hello";
            Console.WriteLine(message.Contains("goodbye"));
            Console.WriteLine(message.Contains("Greetings"));

            Console.WriteLine(message.StartsWith("You"));
            Console.WriteLine(message.StartsWith("goodbye"));
            Console.WriteLine(message.EndsWith("hello"));
            Console.WriteLine(message.EndsWith("goodbye"));


        }
    }
}
