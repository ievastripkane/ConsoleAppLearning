using System;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person;
            person = new Human();
            person.Name = "Ieva";
            person.Surname = "Stripkāne";
            person.Age = 18;
            person.EyeColor = "Blue";

            Console.WriteLine(person.Name + " " + person.Surname);

            person.Name = "Anna";
            Console.WriteLine(person.Name + " " + person.Surname);
        }
    
    }

  







}

