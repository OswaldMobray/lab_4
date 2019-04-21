using System;
using System.Text.RegularExpressions;
using lab_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab_2.Tests
{
    [TestClass]
    public class lab_4Test
    {
        [TestMethod]
        public void AddressReturnTrue()
        {
            string str = "http://google.com";
            bool trexpect = true;
            bool flexpect = false;
            CheckWeb web = new CheckWeb();

            bool actual = web.Check(str);

            Assert.AreEqual(trexpect,actual);
        }
        [TestMethod]
        public void CreateRightAddress()
        {
            CheckWeb web = new CheckWeb();
            bool trexpect = true;
            bool flexpect = false;
            string actual = web.CreateRightAddress("vk", "ru");
            bool actualBool = web.Check(actual);

            Assert.AreEqual(trexpect, actualBool);
        }
        [TestMethod]
        public void IsItMinOrNull ()
        {
            CheckWeb web = new CheckWeb();
            //var actual = web.Min(2,4,7);
            string actual = null;
            Console.WriteLine(actual);
            Assert.IsNull(actual);
        }
        [TestMethod]
        public void IsItMinNotNull()
        {
            CheckWeb web = new CheckWeb();
            var actual = web.Min(2, 4, 7);
            Console.WriteLine(actual);
            Assert.IsNotNull(actual);
        }
        [TestMethod]
        public void IsItContainAddress()
        {
            CheckWeb web = new CheckWeb();
            string actual = web.CreateRightAddress("vk", "ru");
            StringAssert.Contains(actual, "http://");
            
        }
        [TestMethod]
        public void IsItCorrectResultOfRegex()
        {
            CheckWeb web = new CheckWeb();
            string actual = web.CreateRightAddress("vk", "ru");
            StringAssert.Matches(actual,new Regex(@"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$"));
        }
        [TestMethod]
        public void IsItStartRight()
        {
            CheckWeb web = new CheckWeb();
            string actual = web.CreateRightAddress("vk", "ru");
            StringAssert.StartsWith(actual,"http");
        }
    }
}
