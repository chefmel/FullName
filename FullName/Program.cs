using System;
using System.Text;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string myFirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string myLastName = Console.ReadLine();
            Console.WriteLine("Hello " + FullName(myFirstName, myLastName));
            Console.ReadLine();











        }
        private static StringBuilder FullName(string myFirstName, string myLastName)
        {
            StringBuilder myString = new StringBuilder();
            myString.Append(myFirstName);
            myString.Append(" ");
            myString.Append(myLastName);

            return myString;
        }
   }
}
