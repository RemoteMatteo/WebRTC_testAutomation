using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace RemoteSolutions
{

    class ControllerMappings
    {
        IWebDriver driver = WebdriverSingleton.getInstance();

        [SetUp]
        public void Before()
        {
        }

        [Test]
        public void OpenControllerMappingsWebpage()
        {
            driver.Url = "https://browser-streaming-dev.azurewebsites.net/";
        }

        [TearDown]
        public void After()
        {
        }

    }
}