using System;

namespace Enums
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Countries Country { get; set; }

        public Person(Guid id, string name, Countries country)
        {
            Id = id;
            Name = name;
            Country = country;
        }
    }
}