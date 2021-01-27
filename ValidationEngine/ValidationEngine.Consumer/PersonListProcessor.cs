using System;
using ValidationEngine.Library;

namespace ValidationEngine.Consumer
{
    public class PersonListProcessor
    {
        public PersonListProcessor(ValidationRule[] rules)
        {
            ValidationEngine = new Library.ValidationEngine(rules);
        }

        public Library.ValidationEngine ValidationEngine { get; }

        public void Process(Person[]  persons)
        {
            if (persons is null)
            {
                Console.WriteLine("Persons collection is null, nothing to process ...");
                return;
            }

            if (persons.Length == 0)
            {
                Console.WriteLine("Persons collection is empty, nothing to process ...");
                return;
            }

            foreach (Person person in persons)
            {
                bool isValid = ValidationEngine.Validate(person);

                if (isValid)
                {
                    Console.WriteLine($"VALID: {person.FirstName} {person.LastName} CNP={person.CNP}, Age={person.Age}");
                }
                else
                {
                    Console.WriteLine($"NOT VALID: {person.FirstName} {person.LastName} CNP={person.CNP}, Age={person.Age}");
                }
            }
        }
    }
}
