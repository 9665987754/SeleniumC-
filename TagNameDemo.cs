using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;
using System.Threading;
 

namespace SeleniumProject_QA_04
{
    class TagNameDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No Of Links Demo");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\Aaranya\\Bela _SeleniumC#batch\\Selenium_QABatch_IDE\\Selenium_WebDriver_Assignments\\chromedriver");
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://www.google.co.in/";
            //By TagName
            //driver.FindElement(By.TagName("input")).SendKeys("Selenium");
            // Store in The List And Then Print the Size
            ReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("a"));
            //ReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("a"));
            Console.WriteLine(links.Count);
            foreach(IWebElement link in links)
            {
                Console.WriteLine(link.Text);
            }
            //Close the Browser
            Thread.Sleep(3000);
            driver.Close();


        }
    }
}
