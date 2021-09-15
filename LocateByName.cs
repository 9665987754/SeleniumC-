using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumProject_QA_04
{
    class LocateByName
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
            //Enter Selenium in search box: Locate By Name
            //IWebElement search_box = driver.FindElement(By.Name("q"));
            //search_box.SendKeys("Selenium");
            driver.FindElement(By.Name("q")).SendKeys("Selenium");
            //Close the Browser
            driver.Close();

        }
    }
}
