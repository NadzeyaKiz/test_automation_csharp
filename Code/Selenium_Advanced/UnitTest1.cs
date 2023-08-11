using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Selenium_Advanced
{
    public class Tests
    {
        private IWebDriver _driver { get; set; }
        private const string _epamUrl = "https://www.epam.com/";
        private Actions action;
        private WebDriverWait _wait;

        [SetUp, Order(1)]
        public void BrowserSetup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(_epamUrl);
            action = new Actions(_driver);
        }

        [SetUp, Order(2)]
        public void SetUpWaiter()
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _wait.Timeout = TimeSpan.FromSeconds(5);                     
            _wait.PollingInterval = TimeSpan.FromSeconds(0.5);
        }

        [SetUp, Order(3)]
        public void SetUpCookies()
        {
            // accept cookies
            _wait.Until(driver =>
            {
                var cookiesAcceptButtons = _driver.FindElements(By.XPath("//button[@id='onetrust-accept-btn-handler']"));
                if (cookiesAcceptButtons.Count == 1)
                {
                    if (cookiesAcceptButtons[0].Displayed)
                    {
                        cookiesAcceptButtons[0].Click();
                    }
                    
                    return cookiesAcceptButtons[0].Displayed == false;
                }
                return false;
            });
        }

        [Test]
        public void CheckJobListingsUrlTest()
        {
            var expectedJobListingsUrl = "https://www.epam.com/careers/job-listings";
            var careersButton = _driver.FindElement(By.XPath("//*[@href = '/careers' and  contains(@class, 'top-navigation__item-link')]"));
            action.MoveToElement(careersButton).Build().Perform();
            _driver.FindElement(By.XPath("//nav[contains(@class,'top-navigation')]//a[@href='/careers/job-listings']")).Click();
            Assert.That(_driver.Url, Is.EqualTo(expectedJobListingsUrl), "Incorrect URL");
        }
        [Test]
        public void Test2()
        {
            var languagesDropdown = _driver.FindElement(By.XPath("//button[@class='location-selector__button']"));
            languagesDropdown.Click();

            // make sure that the language selection panel is displayed
            var langPanel = _driver.FindElement(By.XPath("//nav[@class='location-selector__panel']"));
            _wait.Until(driver => langPanel.Displayed);

            // check that the required languages are present
            var languagesArray = new List<string> { "(English)", "(Русский)", "(Čeština)", "(Українська)", "(日本語)", "(中文)", "(Deutsch)", "(Polski)" };

            var foundLanduages = _driver
                .FindElements(By.XPath("//nav[@class='location-selector__panel']//a[contains(@class,'location-selector__link')]/span"))
                .Select(x=> x.Text);
            foreach (var language in languagesArray)
            {
                Assert.IsTrue(foundLanduages.Contains(language), $"Language '{language}' was not found in the list.");
            }
        }
        [Test]
        public void Test3()
        {
            var searchIcon = _driver.FindElement(By.XPath("//span[contains(@class,'dark-iconheader-search__search-icon')]"));
            searchIcon.Click();

            ReadOnlyCollection<IWebElement> listOfSearchElements = null;
            _wait.Until(driver =>
            {
                listOfSearchElements = _driver.FindElements(By.XPath("//li[@class='frequent-searches__item']"));
                return listOfSearchElements.Count > 0;
            });
            
            Random random = new Random();
            int randomIndex = random.Next(0, listOfSearchElements.Count);
            _wait.Until(driver =>
            {
                if (listOfSearchElements[randomIndex].Displayed)
                {
                    listOfSearchElements[randomIndex].Click();
                    return true;
                }
                return false;
            });

            var findButton = _driver.FindElement(By.XPath("//*[@class='bth-text-layer']"));
            findButton.Click();

            _wait.Until(driver =>
            {
                var listOfArticles = _driver.FindElements(By.XPath("//article"));
                action.ScrollToElement(listOfArticles[listOfArticles.Count - 1]).Build().Perform();
                var searchViewMoreLink = _driver.FindElements(By.XPath("//a[@class='search-results__view-more button-text']"));

                if (searchViewMoreLink.Count == 1)
                {
                    action.ScrollToElement(searchViewMoreLink[0]).Build().Perform();
                }
                return searchViewMoreLink.Count == 1;
                });

            var listOfArticles = _driver.FindElements(By.XPath("//article"));
            Assert.That(listOfArticles.Count, Is.EqualTo(20));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}