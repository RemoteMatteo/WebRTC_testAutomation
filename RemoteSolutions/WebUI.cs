using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RemoteSolutions
{
    class WebUI
    {

        IWebDriver driver = WebdriverSingleton.getInstance();

        [SetUp]
        public void Before()
        {
        }

        [Test]
        public void OpenWebpage()
        {
            driver.Url = "https://vortex.gg/";
            //verify logo Vortex is visible 
            //verify all the top right buttons are visible 
            //verify download button is visible 
            //verify support button is visible 
        }

        [Test]
        public void RegisterNewUser()
        {
        }
    

        [TearDown]
        public void After()
        {
        }

    }
}