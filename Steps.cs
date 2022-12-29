using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace GitHubAutomation.Steps
{
    public class Steps
    {
        IWebDriver _driver;

        IWebElement _searchForCountry => _driver.FindElement(By.XPath("/html/body/div[1]/sherpa-apps-root/sherpa-apps-map-container/header/nav/sherpa-apps-map-filter/form/div/div[3]/search-ui-destination-search/span/span/sherpa-apps-filter-chip/button/span[1]/div"));


        public void InitBrowser()
        {
            _driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        // 1st test case
        public void OpenAirticketsPage()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.GoToAirticketsPage();
        }

        public void SearchForFlights()
        {
            Pages.AirticketsPageObject airticketsPage = new Pages.AirticketsPageObject(_driver);
            airticketsPage.SearchForFlights();
        }

        // 2nd test case
        public void OpenUSAHotelsPage()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.SearchForUSAHotels();
        }

        public void SortHotelsInAscending()
        {
            Pages.HotelsPageObject hotelsPage = new Pages.HotelsPageObject(_driver);
            hotelsPage.SearchPriceOnly();
        }

        //3rd test case
        public void OpenTokyoHotelsPage()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.SearchForTokyoHotels();
        }

        public void ShowAgodaDiscounts()
        {
            Pages.HotelsPageObject hotelsPage = new Pages.HotelsPageObject(_driver);
            hotelsPage.ShowHotelsOnly();
        }

        // 4th test case
        public void OpenTokyoHotel()
        {
            Pages.HotelsPageObject hotelsPage = new Pages.HotelsPageObject(_driver);
            hotelsPage.ShowHighRankingHotels();
        }

        // 5th test case
        public void ShowFiveStarHotels()
        {
            Pages.HotelsPageObject hotelsPage = new Pages.HotelsPageObject(_driver);
            hotelsPage.ShowFiveStarHotels();
        }

        // 6th test case
        public void VaccineInfo()
        {
            Pages.HotelsPageObject hotelsPage = new Pages.HotelsPageObject(_driver);
            hotelsPage.ShowVaccineRequirements();
        }

        // 7th test case
        public void SortHotelsByPrice()
        {
            Pages.HotelsPageObject hotelsPage = new Pages.HotelsPageObject(_driver);
            hotelsPage.ChoosePool();
        }

        // 8th test case
      

        // 9th test case
        public void OpenPackagiesPage()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.GoToPackagiesPage();
        }

        public void SearchForPackage()
        {
            Pages.PackagesPageObject vacanciesPage = new Pages.PackagesPageObject(_driver);
            vacanciesPage.SearchForPackages();
        }

        // 10th test case
        public void OpenRentalCarPage()
        {
            Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
            mainPage.GoToRentalCarPage();
        }

        public void ShowInfoAboutHowToChooseCar()
        {
            Pages.RentalCarPageObject rentalCarPage = new Pages.RentalCarPageObject(_driver);
            rentalCarPage.ShowInfoAboutChoosingAuto();
        }
    }
}
