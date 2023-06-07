using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    public class UserMessages
    {
        public static void  WelcomeUser(string firstName)
        {       
            Console.Clear();
            Console.WriteLine("Welcome to our Application");
            int hourNow = DateTime.Now.Hour;

            if(hourNow < 12)
            {
                Console.WriteLine($"Good Morning {firstName}");
            } else if (hourNow < 19)
            {
                Console.WriteLine($"Good AfterNoon {firstName}");
            }else
            {
                Console.WriteLine($"Good Evening {firstName}");
            }
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void GreatPerson ( PersonModel person)
        {
            Console.WriteLine($"Welcome {person.FirstName} {person.LastName} ");
            person.HasBeenWelcomed = true;
        }


    }
}
