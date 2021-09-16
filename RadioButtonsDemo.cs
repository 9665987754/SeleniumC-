using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;

namespace SeleniumProject_QA_04
{
    class RadioButtonsDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\Aaranya\\Bela _SeleniumC#batch\\Selenium_QABatch_IDE\\Selenium_WebDriver_Assignments\\chromedriver");
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            ReadOnlyCollection<IWebElement> radio_buttons = driver.FindElements(By.Name("optradio"));
            Thread.Sleep(3000);            
            radio_buttons[1].Click();        
           
            Thread.Sleep(3000);

            //Close the Browser
            driver.Close();

        }


    }
}
