using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            var adults = new Lists().GetAdults(
                new PeopleFactory().Create());
            Assert.IsNotEmpty(adults);
            Assert.Positive(adults.Count);
            adults.ForEach(person => Assert.That(person.Age >= 18));
        }

        [Test]
        public void TestSelectNamesWithA()
        {
            var names = new List<string>();
            new PeopleFactory().Create().ForEach(person => names.Add(person.Name));

            var namesWithA = new LinqTutorial()
                .SelectNamesWithA(names.ToArray())
                .Cast<string>().ToList();

            Assert.Positive(namesWithA.Count);
        }

        [Test]
        public void TestBuggyServiceCreateBook()
        {
            var response = new HttpRequestExample().CreateBook("Mickiewicz", "Dziady", 1882);
            var result = response.Result.Content;
            Assert.NotNull(result);
            Assert.AreEqual(HttpStatusCode.Created, response.Status);
        }

        [Test]
        public void TestBuggyServiceReadBook()
        {
            var response = new HttpRequestExample().GetBook(2001);
            Assert.AreEqual(HttpStatusCode.OK, response.Status);
        }

        [Test]
        public void TestBuggyServiceUpdateBook()
        {
            var book = "{"
                +"'author': {"
                    +"'id': 1001,"
                    +"'lastname': 'Mickiewicz',"
                    +"'name': 'Adam'"
                +"},"
                +"'id': 2002,"
                +"'published': 1881,"
                +"'title': 'Pan Tadeusz'"
            +"}";

            /*TODO
             var response = new HttpRequestExample().PutBook(book);
             Assert.AreEqual(HttpStatusCode.OK, response.Status);*/
            Assert.Fail("Not implemented yet");
        }

        [Test]
        public void TestBuggyServiceDeleteBook()
        {
            Assert.Fail("Not implemented yet");
        }

    }

     class PeopleFactory
    {
        public List<Person> Create()
        {
            return new List<Person> { new Person("Maciek", 10), new Person("Asia", 22), new Person("Zenek",17)
                , new Person("Olek", 62), new Person("Maria", 12), new Person("Kasia",22) };
        }
    }
}
