using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GitHubAutomation.Pages
{
    class RentalCarPageObject
    {
        IWebDriver _driver;

        public RentalCarPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ShowInfoAboutChoosingAuto()
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript($"window.scrollTo({0}, document.body.scrollHeight)");
            Thread.Sleep(5000);
            _driver.FindElement(By.XPath("//*[@id='__next]/footer/div[3]/div/div/ul[1]")).Click();
        }
    }
}
