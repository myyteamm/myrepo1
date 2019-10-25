using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    class DriverFucntions
    {
        public static IWebDriver driver;

        public static void LaunchBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }

        public static void SendKeysAndSynchro(string url)
        {
            driver.Navigate().GoToUrl(url);
  
            driver.FindElement(By.Name("q")).SendKeys("Selenium");
            WebDriverWait driverwait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driverwait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='tsf']/div[2]/div/div[2]/div[2]/ul/li[5]/div/div[1]/div/span"))).Click();
            //driver.FindElement(By.XPath("//span[text()='selenium'][4]")).Click();

            //implicit wait
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //hard coded wait
            //Thread.Sleep(5);
        }

        public static void CloseDriver()
        {
            driver.Close();
        }

        public static string GetTitle()
        {
            return (driver.Title);
        }

        public static void OpenGmail() {
            IWebElement lnk_gmail = driver.FindElement(By.LinkText("Gmail"));
            lnk_gmail.Click();
            Thread.Sleep(10000);
        }

        public static void NaviagtionCommand()
        {
            SendKeysAndSynchro("https://docs.microsoft.com/");
            SendKeysAndSynchro("https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework");
            //Back
            driver.Navigate().Back();

            //forward
            driver.Navigate().Forward();

            //refesh
            driver.Navigate().Refresh();
        }

        public static void LocatorMethod()
        {
            SendKeysAndSynchro("https://rig4/CR.Client/");

            string xpath = "//label[@class='button__content']";

            IWebElement ProceedButton =   driver.FindElement(By.XPath(xpath));

            ProceedButton.Click();

            IAlert a = driver.SwitchTo().Alert();
           
        }
    }
}
