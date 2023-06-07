using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class GuestBook 
    {  
        public static void SayHi()
        {
            Console.WriteLine("Welcome to the Guest Book System");
        }

        public static Dictionary<string,int> GetGuestInformations()
        {
            Console.Write("Enter Guest's Family Name: ");
            string? familyName = Console.ReadLine(); 
            Console.WriteLine("Enter number of Family Members");
            int noOfAttendiees = int.Parse(Console.ReadLine());

            Dictionary<string,int> guestInformation = new Dictionary<string,int>();
            guestInformation.Add(familyName, noOfAttendiees);

            return guestInformation;
        }

        public static void PrintOutGuestInformation()
        {
           var results = GetGuestInformations();

           foreach(KeyValuePair<string,int> pair in results)
            {
               string keys = pair.Key;
               int value = pair.Value;

                Console.WriteLine(keys,value);
            }
            Console.WriteLine($"Total No of People Attending {results.Count}");
        }

        public static void BadCall ()
        {
            string name = "";

            try
            {
                

                Console.WriteLine("What is your name? : ");
                name = Console.ReadLine();

            } catch(Exception) when (name.ToLower() == "tim")
            {
                Console.WriteLine("I don't like this name");
            }
            



        }
    }
}
