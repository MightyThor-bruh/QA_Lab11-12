using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GitHubAutomation.Pages
{
    class HotelsPageObject
    {
        IWebDriver _driver;

        public HotelsPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SearchPriceOnly()
        {
            _driver.FindElement(By.XPath("//*[@id='sorting - selector']/option[2]")).Click();
        }

        public void ShowHotelsOnly()
        {
            _driver.FindElement(By.XPath("//*[@id='__next']/div/div[1]/main/div[2]/div[2]/div/div/div/div[2]/div/ul/li[2]")).Click();
        }

        public void ShowFiveStarHotels()
        {
            _driver.FindElement(By.XPath("//*[@id='__next']/div/div[1]/main/div[2]/div[2]/div/div/div/div[5]/div/div/div/div[2]/section/div[1]/div/button[5]")).Click();
        }

        public void ShowHighRankingHotels()
        {
            _driver.FindElement(By.XPath("//*[@id='__next']/div/div[1]/main/div[2]/div[2]/div/div/div/div[3]/div/div/div/div[2]/section/div/button[1]")).Click();
        }

        public void ShowVaccineRequirements()
        {
            _driver.FindElement(By.XPath("/html/body/div[10]/div/div[1]/div/a/button/div/div/span")).Click();
        }

        public void ChoosePool()
        {
            _driver.FindElement(By.XPath("//*[@id='filter - checkbox - 2']")).Click();
        }
    }
}
