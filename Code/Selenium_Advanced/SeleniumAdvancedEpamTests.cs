using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace Selenium_Advanced
{
    public class SeleniumAdvancedEpamTests
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
        public void LanguagesDroudownListOfLanguadesTest()
        {
            var languagesDropdown = _driver.FindElement(By.XPath("//button[@class='location-selector__button']"));
            //languagesDropdown.Click();

            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)_driver;
            jsExecutor.ExecuteScript("arguments[0].click();", languagesDropdown);

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
        public void NumberOfArticlesOnPageTest()
        {
            var searchIcon = _driver.FindElement(By.XPath("//span[contains(@class,'dark-iconheader-search__search-icon')]"));
            searchIcon.Click();

            /*ensuring that the elements from the Search pannel are present before proceeding further. Once the elements are found, 
             * they are stored in the listOfSearchElements variable, which can be used in further code.  */
            ReadOnlyCollection<IWebElement> listOfSearchElements = null;
            _wait.Until(driver =>
            {
                listOfSearchElements = _driver.FindElements(By.XPath("//li[@class='frequent-searches__item']"));
                return listOfSearchElements.Count > 0;
            });

            /*enerate a random index within the range of the list of search elements, checks if the element at that index is 
             * displayed on the page, and clicks on it if it's displayed. This random selection and interaction with elements 
             * continue until a displayed element is successfully clicked. */
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

            /*scrolling to ensure the last article is visible and checking for the presence of a "View More" link/button. 
             * It continues waiting until the "View More" link/button is found.*/
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