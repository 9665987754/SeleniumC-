using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject_QA_04
{
    class MultiSelectDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\Aaranya\\Bela _SeleniumC#batch\\Selenium_QABatch_IDE\\Selenium_WebDriver_Assignments\\chromedriver");
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            IWebElement select_box = driver.FindElement(By.Name("States"));
            SelectElement select = new SelectElement(select_box);
            Boolean status_multiple = select.IsMultiple;
            Console.WriteLine(status_multiple);
            select.SelectByIndex(4);
            select.SelectByValue("California");
            select.SelectByText("New Jersey");
            //select.DeselectAll();
            select.DeselectByIndex(0);
            //Close the Browser
            //driver.Close();

        }


    }
}
