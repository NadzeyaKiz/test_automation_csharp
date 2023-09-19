using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class EpamTest
    {
        private IWebDriver _driver { get; set; }
        private const string _epamCarersUrl = "https://www.epam.com/careers";

        [SetUp]
        public void BrowserSetup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl(_epamCarersUrl);
            var learnMoreButton = _driver.FindElement(By.XPath("//a[contains(@href,'about/newsroom/press-releases/2022/epam-launches')]"));
            
            Assert.That(learnMoreButton, Is.Not.Null);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}