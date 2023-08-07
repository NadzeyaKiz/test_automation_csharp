using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.WebRequestMethods;

namespace SeleniumBasics
{
    public class SelemiumBasicsEpamPageTests
    {
        private IWebDriver _driver { get; set; }
        private const string _epamUrl = "https://www.epam.com/";

        [SetUp]
        public void BrowserSetup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void NavigateToEpamePageTest()
        {            
            _driver.Navigate().GoToUrl(_epamUrl);            
            var actualUrl = _driver.Url;
            Assert.AreEqual(_epamUrl, actualUrl, "Incorrect EPAM main page Url!");
        }

        [Test]
        public void NavigateToOurWorkUrlWithRefreshTest()
        {
            var howWeDoItUrl = "https://www.epam.com/how-we-do-it";
            var ourWorkUrl = "https://www.epam.com/our-work";
            _driver.Navigate().GoToUrl(howWeDoItUrl);
            _driver.Navigate ().GoToUrl(ourWorkUrl);
            _driver.Navigate().Refresh();
            _driver.Navigate().Back();
            var actualUrl = _driver.Url;

            Assert.AreEqual(howWeDoItUrl, actualUrl, "Incorrect 'How we do it' page Url!");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}