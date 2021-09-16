using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumProject_QA_04
{
    class TitleDemo
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
            String title = driver.Title;
            Console.WriteLine(title);
            // BY LinkText
            driver.FindElement(By.LinkText("Gmail")).Click();      
            title = driver.Title;
            Console.WriteLine(title);
            //Close the Browser
            driver.Close();

        }
    }
}
