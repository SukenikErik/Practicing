using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace GymApp
{
    public class GymService
    {
        private const int MaxCapacity = 50;
        private int TotalIncome = 0;
        private List<Person> persons = new();

        public void Registration()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            int age;
            string input;
            do
            {
                Console.WriteLine("Age: ");
                input = Console.ReadLine();

                if (!int.TryParse(input, out age))
                {
                    Console.WriteLine("Please, Enter you age in number format.");
                }
            } while (!int.TryParse(input, out age));
            if (age < 14)
            {
                Console.WriteLine("You cannot register under the age of 14.");
            }

            string genderInput;
            do
            {
                Console.WriteLine("Gender: Male/Female");
                genderInput = Console.ReadLine().ToLower();
                if (genderInput != "male" && genderInput != "female")
                {
                    Console.WriteLine("Please choose between Male of Female");
                }
            } while (genderInput != "male" && genderInput != "female");
            var gender = genderInput == "Female" ? Gender.Female : Gender.Male;


            string employeeInput;
            do
            {
                Console.WriteLine("Employee? (y/n):");
                employeeInput = Console.ReadLine().ToLower();
                if (employeeInput != "y" && employeeInput != "n")
                {
                    Console.WriteLine("Please choose between y or n");
                }
            } while (employeeInput != "y" && employeeInput != "n");

            var employee = employeeInput == "y";

            persons.Add(new Person
            {
                Name = name,
                Age = age,
                Gender = gender,
                Employee = employee,
                Times = 0,
                IsInside = false

            });

            Console.WriteLine("Sikeres regisztáció!");
        }

        public void PurchaseOccasion()
        {
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            var person = persons.FirstOrDefault(e => e.Name == name);
            if (person == null || person.Employee)
            {
                Console.WriteLine("You are not registered, or you are an employee.");
                return;
            }

            int price = person.Gender == Gender.Female ? 1000 : 2000;
            Console.WriteLine($"Price for one session: {price} Ft");
            
            int pcs;
            string input;

            do
            {
                Console.WriteLine("How many sesssions do you wish to purchase?: ");
                input = Console.ReadLine();

                if (!int.TryParse(input, out pcs))
                {
                    Console.WriteLine("Only numbers are allowed.");
                }
            } while (!int.TryParse(input, out pcs));
            person.Times += pcs;
            TotalIncome += pcs * price;
            Console.WriteLine($"Succesful purchase. Number of sessions avaible: {person.Times}");
        }

        public void Enter()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            var person = persons.FirstOrDefault(e => e.Name == name);
            if (person == null)
            {
                Console.WriteLine("There is no registered person with this name.");
                return;
            }
            if (person.IsInside)
            {
                Console.WriteLine("This person is already inside.");
                return;
            }

            int personsInside = persons.Count(e => e.IsInside && !e.Employee);
            if (!person.Employee && personsInside <= MaxCapacity)
            {
                Console.WriteLine("The gym is full.");
                return;
            }

            if (!person.Employee && person.Times < 1)
            {
                Console.WriteLine("You didn't purchase enough session");
                return;
            }

            if (!person.Employee)
            {
                person.Times--;
            }

            person.IsInside = true;
            Console.WriteLine($"{name} entered the gym");
        }

        public void Exit()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            var person = persons.FirstOrDefault(e => e.Name == name);
            if (person == null || !person.IsInside)
            {
                Console.WriteLine("This person isn't inside the gym.");
                return;
            }

            person.IsInside = false;
            Console.WriteLine($"{name} succesfully exited the gym");

        }

        public void Status()
        {
            Console.WriteLine("\n --- Persons Inside ---");
            foreach (var e in persons.Where(e => e.IsInside))
            {
                Console.WriteLine($"{e.Name} (Employee: {(e.Employee ? "Yes" : "No")})");
            }

            int guestsInside = persons.Count(e => e.IsInside && !e.Employee);
            Console.WriteLine($"\n In total {guestsInside}/50 are inside the gym. ");

            Console.WriteLine($"Total income : {TotalIncome}");
        }
    }
}
