using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

namespace SeleniumMSTestReport

{
    public class BaseClass
    {
        public static IWebDriver driver;
        public static string path;
        public static void DriverInit()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("Incognito");
            driver = new ChromeDriver(options);

        }
        public static void DriverCLose()
        {

            driver.Close();
        }
        public static void OpenUrl(string link)
        {
                driver.Url = link;    
        }
        public static void Assertion(By locator, string expectedText)
        {
            string actualText = driver.FindElement(locator).Text;
            Assert.AreEqual(expectedText, actualText);
        }
        public static void Write(By locator, string value)
        {
               driver.FindElement(locator).SendKeys(value);            
        }
        public static void Click(By locator)
        {
                driver.FindElement(locator).Click();
                
        }
      
    }
}