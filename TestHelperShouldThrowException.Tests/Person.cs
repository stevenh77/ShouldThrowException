using System;
namespace TestHelperShouldThrowException.Tests
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            if (string.IsNullOrEmpty(name)) 
                throw new ArgumentException("Invalid name value");

            Name = name;
        }
    }
}
