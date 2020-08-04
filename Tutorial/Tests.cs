using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Tests
    {

        [Test]
        public void TestSquare()
        {
            var result = new Functions().square(2);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void TestStringLen()
        {
            Assert.AreEqual(11, new Functions().stringLen("Ala ma kota"));
        }

        [Test]
        public void TestGetAdults()
        {
            new Lists().GetAdults(
                new PeopleFactory().Create())
                .ForEach(person => Assert.That(person.age >= 18));
        }
    }

     class PeopleFactory
    {
        public List<Person> Create()
        {
            return new List<Person> { new Person(10), new Person(22), new Person(17), new Person(62), new Person(12), new Person(22) };
        }
    }
}
