using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace EasyDependencies
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new FirefoxDriver();
            var cookies = driver.Manage().Cookies.AllCookies;
            var url = driver.Url;
        }
    }
}
