using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GitHubAutomation.Pages
{
    class MainPageObject
    {
        IWebDriver _driver;

        public MainPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public AirticketsPageObject GoToAirticketsPage()
        {
            _driver.FindElement(By.XPath("//*[@id='__next'']/div[1]/div[4]/header/div[1]/nav/ul/li[3]/a")).Click();

            return new AirticketsPageObject(_driver);
        }

        public HotelsPageObject SearchForUSAHotels()
        {
            _driver.FindElement(By.XPath("//*[@id='input - auto - complete]")).Click();
            _driver.FindElement(By.XPath("//*[@id='input - auto - complete]")).SendKeys("Paris");

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //_driver.FindElement(By.XPath("//span[text()='Торревьеха']")).Click();

            _driver.FindElement(By.XPath("//*[@id='__next']/div[1]/main/div[3]/div[2]/div/div[3]/div/div/form/fieldset/div/div[1]/button")).Click();
            _driver.FindElement(By.XPath("//*[@id='__next']/div[1]/main/div[3]/div[2]/div/div[3]/div/div/form/div[4]/div/div/div[2]/div/div[3]/div/div/div/div[1]/table/tbody/tr[5]/td[6]/time/button")).Click();
            _driver.FindElement(By.XPath("//*[@id='__next']/div[1]/main/div[3]/div[2]/div/div[3]/div/div/form/div[4]/div/div/div[2]/div/div[3]/div/div/div/div[1]/table/tbody/tr[5]/td[7]/time/button")).Click();
            _driver.FindElement(By.XPath("//*[@id='__next']/div[1]/main/div[3]/div[2]/div/div[3]/div/div/form/div[3]/button")).Click();

            return new HotelsPageObject(_driver);
        }

        public HotelsPageObject SearchForTokyoHotels()
        {
            _driver.FindElement(By.XPath("//*[@id='input - auto - complete]")).Click();
            _driver.FindElement(By.XPath("//*[@id='input - auto - complete]")).SendKeys("Tokyo");

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //_driver.FindElement(By.XPath("//span[text()='Токио']")).Click();

            _driver.FindElement(By.XPath("//*[@id='__next']/div[1]/main/div[3]/div[2]/div/div[3]/div/div/form/fieldset/div/div[1]/button")).Click();
            _driver.FindElement(By.XPath("//*[@id='__next']/div[1]/main/div[3]/div[2]/div/div[3]/div/div/form/div[4]/div/div/div[2]/div/div[3]/div/div/div/div[1]/table/tbody/tr[5]/td[6]/time/button")).Click();
            _driver.FindElement(By.XPath("//*[@id='__next']/div[1]/main/div[3]/div[2]/div/div[3]/div/div/form/div[4]/div/div/div[2]/div/div[3]/div/div/div/div[1]/table/tbody/tr[5]/td[7]/time/button")).Click();
            
            _driver.FindElement(By.XPath("//*[@id='__next']/div[1]/main/div[3]/div[2]/div/div[3]/div/div/form/div[3]/button")).Click();


            return new HotelsPageObject(_driver);
        }

        

        public PackagesPageObject GoToPackagiesPage()
        {
            //Thread.Sleep(3000);
            //IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            //js.ExecuteScript($"window.scrollTo({0},{1500})");
            _driver.Navigate().GoToUrl("https://www.trivago.com/en-US/vrt/packages");

            return new PackagesPageObject(_driver);
        }

        public RentalCarPageObject GoToRentalCarPage()
        {
            _driver.Navigate().GoToUrl("https://www.trivago.com/en-US/vrt/cars");

            return new RentalCarPageObject(_driver);
        }
    }
}
