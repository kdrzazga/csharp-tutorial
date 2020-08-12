using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Lists
    {
        public IList<int> FindPositive(List<int> list)
        {
            return list.FindAll(element => element > 0);
        }

        public List<Person> GetAdults(List<Person> people)
        {
            return people.FindAll(person => person.Age >= 18);
        }
    }

    class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    
}
