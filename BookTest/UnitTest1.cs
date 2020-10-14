using System;
using MandatoryAssignment1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTtileMethodLongerThan2Char()
        {
            Book book1 = new Book("Captain Hook", "J. M. Barrie",20, "0000000000000");
            string actualResult = book1.Title;
            Assert.AreEqual("Captain Hook", actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTtileMethodShorterThan2Char()
        {
            Book book2 = new Book("N","no", 20, "0000000000000");
            string actualResult = book2.Title;
            Assert.AreEqual(typeof(ArgumentException), actualResult);
        }

        [TestMethod]
        public void TestPageNumberMethodRightAmount()
        {
            Book book3 = new Book("Sleeping Beauty", "Charles Perrault", 50,"0000000000000");
            int actualResult = book3.PageNumber;
            Assert.AreEqual(50, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPageNumberMethodShorterThan10()
        {
            Book book4 = new Book("Ugly Duckling", "Hans Christian Andersen",6,"0000000000000");
            int actualResult = book4.PageNumber;
            Assert.AreEqual(typeof(ArgumentException), actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPageNumberMethodLongerThan1000()
        {
            Book book5 = new Book("Snow White","Grimms", 3000, "0000000000000");
            int actualResult = book5.PageNumber;
            Assert.AreEqual(typeof(ArgumentException), actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPageNumberMethodEqualsTo1000()
        {
            Book book6 = new Book("Man", "smth", 1000, "0000000000000");
            int actualResult = book6.PageNumber;
            Assert.AreEqual(typeof(ArgumentException), actualResult);
        }

    }
}
