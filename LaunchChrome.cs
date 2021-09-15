using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumProject_QA_04
{
    class LaunchChrome
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
            //Close the Browser
            driver.Close();
            
        }
    }
}
