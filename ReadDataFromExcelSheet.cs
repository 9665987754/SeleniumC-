using NPOI.HSSF.UserModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace SeleniumProject_QA_04
{
    
    class ReadDataFromExcelSheet
    {
        public static List<String> ReadDataFromExcel(String path)
        {
            HSSFWorkbook wb = new HSSFWorkbook(File.Open(path, FileMode.Open));
            HSSFSheet sh = (HSSFSheet)wb.GetSheetAt(0);
            HSSFRow row = (HSSFRow)sh.GetRow(0);
            HSSFCell cell = null;
            List<String> cell_values = new List<string>();
            int i, j;
            for (i = 1; i <= sh.LastRowNum; i++)
            {
                int cell_count = sh.GetRow(0).LastCellNum;
                for (j = 0; j < cell_count; j++)
                {
                    cell = (HSSFCell)sh.GetRow(i).GetCell(j);
                    String cell_value = cell.StringCellValue;
                    cell_values.Add(cell_value);
                }

            }
            return cell_values;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver();
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://www.google.co.in";
            String path = @"C:\Users\Aaranya\Bela _SeleniumC#batch\Selenium_QABatch_IDE\Selenium_WebDriver_Assignments\SeleniumProject_QA_04_Updated\cities.xls";
            //WorkBook->Sheet->Row->Cell
            //.xls -> HSSF
            List<String> cell_values = ReadDataFromExcel(path);
            foreach(String cell_value in cell_values)
            {
                Console.WriteLine(cell_value);
            }
            driver.FindElement(By.Name("q")).SendKeys(cell_values[2]);
            driver.FindElement(By.LinkText("Gmail")).Click();
            driver.FindElement(By.PartialLinkText("Sign")).Click();
            driver.FindElement(By.Id("identifierId")).SendKeys(cell_values[3]);
            driver.Quit();

        }
    }
}
