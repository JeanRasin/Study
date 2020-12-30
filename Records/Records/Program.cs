using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person() { Name = "Tom", Age = 33 };
            // person1.Name = "Ivan"; error
            var person2 = new Person() { Name = "Tom", Age = 33 };
            Console.WriteLine(person1.Equals(person2)); // result false
            Console.WriteLine(person1 == person2);// result false

            Console.WriteLine(new string('-', 10));

            var user1 = new User() { Name = "Tom", Age = 33 };
            var user2 = new User() { Name = "Tom", Age = 33 };
            Console.WriteLine(user1.Equals(user2)); // result true
            Console.WriteLine(user1 == user2); // result true

            Console.WriteLine(new string('-', 10));

            // Меняем одно свойство
            user2 = user1 with { Name = "Bob" };
            Console.WriteLine(user2);

            Console.WriteLine(new string('-', 10));

            var people = new People("Andre", 20);

            var (peopleName, peopleAge) = people;
            Console.WriteLine($"Name: {peopleName}, Age: {peopleAge}");

        }
    }

    public class Person
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }

    public record User
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }

    public record People
    {
        public string Name { get; init; }
        public int Age { get; init; }

        public People(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Deconstruct(out string peopleName, out int peopleAge) => (peopleName, peopleAge) = (Name, Age);
    }
}
