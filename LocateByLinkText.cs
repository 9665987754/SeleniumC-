using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumProject_QA_04
{
    class LocateByLinkText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\Aaranya\\Bela _SeleniumC#batch\\Selenium_QABatch_IDE\\Selenium_WebDriver_Assignments\\chromedriver");
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://www.google.co.in/";
            // BY LinkText
            //driver.FindElement(By.LinkText("Gmail")).Click();
            //Get InnerText of the webElement
            String gmailText = driver.FindElement(By.LinkText("Gmail")).Text;
            Console.WriteLine(gmailText);
            //Close the Browser
            driver.Close();

        }
    }
}
