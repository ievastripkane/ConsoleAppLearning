using System;
using System.Collections.Generic;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();
            persons.Add(new Human("Ieva", "S", 18, "Blue"));
            persons.Add(new Human("Ralfs", "B", 20, "Blue"));
            persons.Add(new Human("Miralda", "S", 68, "Brown"));
            persons.Add(new Human("Jolanta", "B", 44, "Green"));

            persons[1].SetAge(15);

            //persons[0].Introduce();
            //persons[1].Introduce();
            //persons[2].Introduce();
            //persons[3].Introduce();

            //for (int i = 0; i < persons.Count; i++)
            //{
            // persons[1].Introduce();
            //}

            foreach(var person in persons)
            {
              person.Introduce();
            }

            //create some accounts here
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount());


        }
    
    }

  







}

