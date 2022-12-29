using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GitHubAutomation.Pages
{
    class AirticketsPageObject
    {
        IWebDriver _driver;

        public AirticketsPageObject(IWebDriver driver)
        {
            _driver = driver;
        }   

        public void SearchForFlights() 
        {
            _driver.FindElement(By.XPath("//*[@id='c7E3S -switch-list - wrapper']")).Click();

            _driver.FindElement(By.XPath("//*[@id='eFvP - origin - airport']")).Clear();
            _driver.FindElement(By.XPath("//*[@id='eFvP - origin - airport']")).SendKeys("Vilnius(VNO)");

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.XPath("//*[@id='ap - VNO / 7110']")).Click();

            _driver.FindElement(By.XPath("//*[@id='eFvP - destination - airport']")).SendKeys("Paris (PAR)");

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.XPath("//*[@id='ap - PAR / 36014']")).Click();

            _driver.FindElement(By.XPath("//*[@id='eFvP - dateRangeInput - display']")).Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.XPath("//*[@id='stl - jam - cal - 202212']/div/div[3]/div[5]/div[5]")).Click();

            _driver.FindElement(By.XPath("//*[@id='WQty - submit']")).Click(); 
        }
    }
}
