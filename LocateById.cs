using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumProject_QA_04
{
    class LocateById
    {
        static void Main(string[] args)
        {
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\Aaranya\\Bela _SeleniumC#batch\\Selenium_QABatch_IDE\\Selenium_WebDriver_Assignments\\chromedriver");
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F%26ogbl%2F&ltmpl=default&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp";
            //driver.FindElement(By.Id("firstName")).SendKeys("Bela");
               //OR 
            driver.FindElement(By.CssSelector("#firstName")).SendKeys("Bela");

            Thread.Sleep(3000);
            //Close the Browser
            driver.Close();

        }
    }
}
