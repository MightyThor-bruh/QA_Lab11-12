using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GitHubAutomation.Pages
{
    class PackagesPageObject
    {
        IWebDriver _driver;

        public PackagesPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SearchForPackages()
        {
            _driver.FindElement(By.XPath("//*[@id='ZXGJ']/div[6]/div/div[2]/div[1]/div[2]/div/input")).Click();
            _driver.FindElement(By.XPath("//*[@id='ZXGJ']/div[6]/div/div[2]/div[1]/div[2]/div/input")).SendKeys("Las Vegas");

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.XPath("//*[@id='ZXGJ']/div[6]/div/div[2]/div[1]/div[2]/div/input")).Click();
            _driver.FindElement(By.XPath("//*[@id='ZXGJ']/div[6]/div/div[2]/div[1]/div[2]/div/input")).SendKeys("Marseille (MRS)");

            _driver.FindElement(By.XPath("//*[@id='ZXGJ']/div[6]/div/div[2]/div[1]/div[1]/div")).Click();
            _driver.FindElement(By.XPath("//*[@id='ZXGJ']/div[6]/div/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[12]")).Click();
            _driver.FindElement(By.XPath("//*[@id='ZXGJ']/div[6]/div/div[2]/div[2]/div/div/div[2]/div[2]/div[2]/div[10]")).Click();

            _driver.FindElement(By.XPath("//*[@id='searchForm']/div/div/div[2]/div[2]/div/button")).Click();


            return /*new PackagesPageObject(_driver)*/;
        }
    }
}
