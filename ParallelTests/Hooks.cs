using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace ParallelTests
{
    public enum BrowserType
    {
        Chrome,
        FireFox,
        IE,
        RemoteDriver
    }

    public class Hooks : Base
    {
        private BrowserType _browserType;

        public Hooks(BrowserType browserType)
        {
            _browserType = browserType;
        }

        [SetUp]
        public void InitialBrowser()
        {
            ChooseBrowser(_browserType);
        }

        private void ChooseBrowser(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
            {
                Driver = new ChromeDriver();
            }
            else if (browserType == BrowserType.FireFox)
            {
                Driver = new FirefoxDriver();
            }
            else if (browserType == BrowserType.RemoteDriver)
            {
                ChromeOptions options = new ChromeOptions();
                Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            }
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
