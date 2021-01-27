using System;

namespace ValidationEngine.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new[]
            {
                new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                    CNP = "1410313510027",
                    Age = 80
                },
                new Person
                {
                    FirstName = "Petre",
                    LastName = "Daea",
                    CNP = "1300812420055",
                    Age = 95
                },
                new Person
                {
                    FirstName = "Elena",
                    LastName = "Basescu",
                    CNP = "2720428390052",
                    Age = 25
                }
            };

            PersonListProcessor processor = new PersonListProcessor(
                new Library.ValidationRule[] { });

            processor.Process(persons);
        }
    }
}
