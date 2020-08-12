using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWrapper;

namespace MSTests
{
    [TestClass]
    public class Tests
    {
        [TestInitialize]
        public void Setup()
        {
            var driver = new FirefoxDriver("C:\\Users\\kdrzazga\\webdriver");
            Utils.MaximizeWindow(driver);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestCleanup]
        public void TearDown()
        {
            // Runs after each test. (Optional)
        }

    }
}
