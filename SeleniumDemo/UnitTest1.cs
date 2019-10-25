using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumDemo;

namespace SeleniumDemo
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
           string URL = "https://google.com";
           DriverFucntions.LaunchBrowser();
           DriverFucntions.SendKeysAndSynchro(URL);
           //URL= DriverFucntions.GetTitle();
           // DriverFucntions.OpenGmail();
           // DriverFucntions.CloseDriver();
        }

        [TestMethod]
        public void TestMethod2()
        {
            DriverFucntions.NaviagtionCommand();
        }

        [TestCleanup]
        public void Cleanup()
        {
            DriverFucntions.CloseDriver();
        }
    }
}
