using NUnit.Framework;
using SeleniumWrapper;

namespace Tests
{
    public class UtilsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var cookies = Utils.GetCookies(new System.Uri("https://www.seleniumeasy.com/"));
            Assert.IsNotNull(cookies);
            Assert.Pass();
        }
    }
}