using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumProject_QA_04
{
    class RelativeXpathDemo
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
            // BY Relative Xpath
            driver.FindElement(By.XPath("//input[@role='combobox']")).SendKeys("Selenium");
            //Close the Browser
            driver.Close();


        }
    }
}
