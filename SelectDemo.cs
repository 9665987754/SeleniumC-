using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumProject_QA_04
{
    class SelectDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\Aaranya\\Bela _SeleniumC#batch\\Selenium_QABatch_IDE\\Selenium_WebDriver_Assignments\\chromedriver");
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://formstone.it/components/dropdown/demo/";
            IWebElement select_box = driver.FindElement(By.Id("demo_basic"));
            SelectElement select = new SelectElement(select_box);
            //select.SelectByIndex(1);
            //select.SelectByValue("2");
            select.SelectByText("Two");
            //Close the Browser
            driver.Close();

        }


    }
}
