using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Interactions;

namespace SeleniumProject_QA_04
{
    class MouseActionDemo
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
            IWebElement gmail = driver.FindElement(By.LinkText("Gmail"));
            Actions action = new Actions(driver);
            //Click using Mouse
            //action.MoveToElement(gmail).Click().Perform();
            //Hover on the Element
            //action.MoveToElement(gmail).Build().Perform();
            //Right Click the Element
            //action.MoveToElement(gmail).ContextClick().Perform();
            //double Click
            action.MoveToElement(gmail).DoubleClick().Perform();
            //Close the Browser
            driver.Close();

        }
    }
}
