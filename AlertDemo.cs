using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumProject_QA_04
{
    class AlertDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\Aaranya\\Bela _SeleniumC#batch\\Selenium_QABatch_IDE\\Selenium_WebDriver_Assignments\\chromedriver");
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://www.seleniumeasy.com/test/javascript-alert-box-demo.html";
            //Click on Button To get Alert
            driver.FindElement(By.CssSelector("button.btn")).Click();
            //Read the Alert
            IAlert alert = driver.SwitchTo().Alert();
            String alert_Text = alert.Text;
            Console.WriteLine(alert_Text);
            Thread.Sleep(3000);
            //Respond Alert
            alert.Accept();
            //driver.Close();

        }


    }
}
