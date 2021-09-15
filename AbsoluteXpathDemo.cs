using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumProject_QA_04
{
    class AbsoluteXpathDemo
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
            // BY Absolute
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys("Selenium");
            //Close the Browser
            driver.Close();


        }
    }
}
