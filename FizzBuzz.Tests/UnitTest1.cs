using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(3, "Fizz");
            dict.Add(5, "Buzz");

            FizzBuzz x = new FizzBuzz();
            int i = 0;
            string result = string.Empty;
            //Act
            foreach (string item in x.Numbers(15, dict))
            {
                if (++i == 15)
                {
                    result = item;
                }
            }

            //Assert

            Assert.AreEqual(result, "15 FizzBuzz");
        }

        [TestMethod]
        public void TestMillion()
        {
            //Arrange
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(3, "Fizz");
            dict.Add(5, "Buzz");
            dict.Add(1000000, "Million");

            FizzBuzz x = new FizzBuzz();
            int i = 0;
            string result = string.Empty;
            //Act
            foreach (string item in x.Numbers(1000000, dict))
            {
                if (++i == 1000000)
                {
                    result = item;
                    break;
                }
            }

            //Assert
            Assert.AreEqual("1000000 BuzzMillion", result);
        }
    }
}
