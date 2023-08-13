using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace SeleniumBasics2
{
    public class SeleniumBasicsEpamTests2
    {
        private IWebDriver _driver { get; set; }
        private const string _epamUrl = "http://www.epam.com/";
        string _cookiesAcceptButtonLocator = "//button[@id='onetrust-accept-btn-handler']";
        string _searchIconLocator = "//span[contains(@class,'dark-iconheader-search__search-icon')]";
        string _searchInputLocator = "new_form_search";
        string _searchButtonLocator = ".//*[@class='bth-text-layer']";

        [SetUp]
        public void SetUpBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(_epamUrl);
        }

        [Test]
        public void CheckAvaliableCountriesTest()
        {
            string [] locationTextConstantsCollection = { "AMERICAS", "EMEA", "APAC" };
            var searchCareersButtonLocator = By.XPath("//*[contains(@class,'top-navigation')][@href='/careers']");
            _driver.FindElement(searchCareersButtonLocator).Click();                        
            _driver.FindElement(By.XPath(_cookiesAcceptButtonLocator)).Click();
            var findYourDreamJobButtonLocator = By.XPath("//div[@class='owl-item active']//a[@href='/careers/job-listings']");

            _driver.FindElement(findYourDreamJobButtonLocator).Click();
            Thread.Sleep(3000);
            var searchLocationElementsLocator = By.XPath("//div[contains(@class,'tabs-links-list')]//a");
            var locationElements = _driver.FindElements(searchLocationElementsLocator);            
            var locationElementTexts = locationElements.Select(element => element.Text).ToList();
            
            CollectionAssert.AreEquivalent(locationTextConstantsCollection, locationElementTexts);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [Test]
        public void CheckFirstFiveArticleTest(int articleIndex) 
        {
            var textToSearch = "Automation";
            var expectedOpendPageUrl = $"https://www.epam.com/search?q={textToSearch}";

            _driver.FindElement(By.XPath(_searchIconLocator)).Click();
            Thread.Sleep(2000);                     
            var searchInput = _driver.FindElement(By.Id(_searchInputLocator));
            searchInput.SendKeys(textToSearch);                        
            _driver.FindElement(By.XPath(_searchButtonLocator)).Click();
            
            Assert.AreEqual(expectedOpendPageUrl, _driver.Url, "Invalid opend page Url");
            Thread.Sleep(3000);
                       
            _driver.FindElement(By.XPath(_cookiesAcceptButtonLocator)).Click();
            Thread.Sleep(1000);            
            var firstFiveArticleLocator = By.XPath($"//div[@class='search-results__items']/article//a");
            var numberOfResults = _driver.FindElements(firstFiveArticleLocator).Count();
            
            // If there are at least 5 results, check the text of the first five results
            if (articleIndex <= numberOfResults)
            {               
                _driver.FindElement(firstFiveArticleLocator).Click();

                var searchTextOfArticle = _driver.PageSource;
                bool isStringPresent = searchTextOfArticle.Contains(textToSearch, StringComparison.OrdinalIgnoreCase);

                Assert.IsTrue(isStringPresent, $"The word '{textToSearch}' is NOT present on the web page of the {articleIndex} article.");
            }
            else
            {
                Assert.Inconclusive($"There are less than {articleIndex} search results.");
            }
        }

        [Test]
        public void CheckFirstArticleTest() 
        {
            var textToSearch = "Business Analysis";
            var textToSearchInUrlIncoding = textToSearch.Replace(" ", "+");
            var expectedOpendPageUrl = $"https://www.epam.com/search?q={textToSearchInUrlIncoding}";
                        
            _driver.FindElement(By.XPath(_searchIconLocator)).Click();            
            var searchInput = _driver.FindElement(By.Id(_searchInputLocator));
            searchInput.SendKeys(textToSearch);                        
            _driver.FindElement(By.XPath(_searchButtonLocator)).Click();
            
            Assert.AreEqual(expectedOpendPageUrl, _driver.Url, "Invalid opend page Url");

            Thread.Sleep(3000);           
            _driver.FindElement(By.XPath(_cookiesAcceptButtonLocator)).Click();
            Thread.Sleep(1000);

            var firstArticleLocator = By.XPath("//div[@class='search-results__items']/article[1]//a");
            var firstArticle = _driver.FindElement(firstArticleLocator).Text;
            _driver.FindElement(firstArticleLocator).Click();
            var titleOfOpendFirstArticleLocator = By.XPath("//*[@class='museo-sans-light']");            
            var actualTitleOfOpendFirstArticlePage = _driver.FindElement(titleOfOpendFirstArticleLocator).Text;

            Assert.AreEqual(firstArticle, actualTitleOfOpendFirstArticlePage, "Invalid first article Title");
        }

        /*Task Write xPath locators for any elements using:
         * 1. Keyword contains: => //button[contains(@class, 'hamburger')]    This XPath locates all <button> elements that have a class attribute containing the word "humburger'.
         * 2. axis following-sibling/preceding-sibling: => //section//following-sibling::*[contains(@href, 'contact')]  ;  //div[@class='search-results__items']/child::article[1]//h3/following-sibling::p
         *              //div[@class='search-results__items']/child::article[1]//p/preceding-sibling::h3
         * 3. axis parent: => //div[@class='search-results__items']//p/parent::article
         * 4. axis first/last: => //div[@class='search-results__items']//article[1]  ;  //div[@class='search-results__items']//article[last()]
         * 5. axis child (and verify that we can get rid of it using // or /) => //div[@class='search-results__items']/child::article[1]//a or //div[@class='search-results__items']/article[1]//a
         */

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }        
    }
}