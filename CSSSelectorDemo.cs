using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumProject_QA_04
{
    class CSSSelectorDemo
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
            // BY CSS Selector Xpath
            //driver.FindElement(By.CssSelector("input.gLFyf")).SendKeys("Selenium");
            //By Attribute
            //driver.FindElement(By.CssSelector("input[role='combobox']")).SendKeys("Selenium");
            //Starts with
            //driver.FindElement(By.CssSelector("input[role^='combo']")).SendKeys("Selenium");
            //Contains
            //driver.FindElement(By.CssSelector("input[role*='mbo']")).SendKeys("Selenium");
            //Ends-With
            driver.FindElement(By.CssSelector("input[role$='box']")).SendKeys("Selenium");

            //Close the Browser
            Thread.Sleep(3000);
            driver.Close();


        }
    }
}
