using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkWithGit;
namespace WorkWithGitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum10_20_return30()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            Book b = new Book();
            int actual = b.Sum(x, y);

            //asssert
            Assert.AreEqual(expected, actual);
        }
    }
}
