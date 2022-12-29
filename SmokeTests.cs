using NUnit.Framework;

namespace GitHubAutomation
{
    [TestFixture]
    public class SmokeTests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            //steps.CloseBrowser();
        }

        [Test]
        public void SearchForFlightToParisFromVilnius()
        {
            steps.OpenAirticketsPage();
            steps.SearchForFlights();
        }

        [Test]
        public void SortHotelsPriceInAscendingOrder()
        {
            steps.OpenUSAHotelsPage();
            steps.SortHotelsInAscending();
        }

        [Test]
        public void DiscountFromAgoda()
        {
            steps.OpenTokyoHotelsPage();
            steps.ShowAgodaDiscounts();
        }

        [Test]
        public void ShowTokyoHotelInfo()
        {
            steps.OpenTokyoHotelsPage();
            steps.OpenTokyoHotel();
        }

        [Test]
        public void ShowFiveStarTokyoHotels()
        {
            steps.OpenTokyoHotelsPage();
            steps.ShowFiveStarHotels();
        }

        [Test]
        public void ShowVaccineRequirements()
        {
            steps.OpenUSAHotelsPage();
            steps.VaccineInfo();
        }

        [Test]
        public void SortByPrice()
        {
            steps.OpenTokyoHotelsPage();
            steps.SortHotelsByPrice();
        }


        [Test]
        public void ShowAvailablePackages()
        {
            steps.OpenPackagiesPage();
            steps.SearchForPackage();
        }

        [Test]
        public void InfoHowToChooseCar()
        {
            steps.OpenRentalCarPage();
            steps.ShowInfoAboutHowToChooseCar();
        }
    }
}
