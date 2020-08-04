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
            return people.FindAll(person => person.age >= 18);
        }
    }

    class Person
    {
        public int age { get; }

        public Person(int age)
        {
            this.age = age;
        }
    }

    
}
