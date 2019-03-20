using System.Threading;
using NUnit.Framework;

namespace ParallelTests
{
    [TestFixture]
    [Parallelizable]
    public class ChromeBrowser : Hooks
    {
        public ChromeBrowser() : base(BrowserType.Chrome)
        {

        }
        [Test]
        public void ChromeTest()
        {
            Driver.Navigate().GoToUrl("https://web.postman.co");
            Thread.Sleep(3000);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class FirefoxBrowser : Hooks
    {
        public FirefoxBrowser() : base(BrowserType.FireFox)
        {
        }
        [Test]
        public void FirefoxTest()
        {
            Driver.Navigate().GoToUrl("https://rapidapi.com");
            Thread.Sleep(3000);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class SeleniumGrid : Hooks
    {
        public SeleniumGrid() : base(BrowserType.RemoteDriver)
        {
        }
        [Test]
        public void RemoteTest()
        {
            Driver.Navigate().GoToUrl("https://rapidapi.com");
            Thread.Sleep(3000);
        }
    }
}
