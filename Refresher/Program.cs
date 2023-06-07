using Refresher;
using DemoLibrary;


List<PersonModel> people = new List<PersonModel>();
string firstName = string.Empty;

do
{
    
    Console.WriteLine("Please Enter your first Name?:");
    firstName = Console.ReadLine();

    if(firstName != "exit")
    {
        Console.WriteLine("Please Enter your second Name?: ");
        string lastName = Console.ReadLine();

        PersonModel person = new PersonModel();

        person.FirstName = firstName;
        person.LastName = lastName;

        people.Add(person);
    }

} while (firstName.ToLower() != "exit");

foreach(PersonModel person in people)
{
    Console.WriteLine(person.FullName);
}

