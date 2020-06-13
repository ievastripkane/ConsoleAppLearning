using System;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();
            person.Name = "Ieva";
            person.Surname = "S";
            person.Age = 18;
            person.EyeColor = "Blue";
            person.Introduce();

            person.Name = "Anna";
            person.Introduce();

            person.AddNumbers(12, 52);
        }
    
    }

  







}

