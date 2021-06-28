using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace RemoteSolutions
{
    class WebdriverSingleton
    {
        //TODO: Relative path
        static string ChromeDriverDirectory = "C:\\Users\\opitz\\source\\repos\\WebRTC_testAutomation\\RemoteSolutions\\" + Resources.ChromeDriverPath;


        public static IWebDriver driver;

        public static IWebDriver getInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(ChromeDriverDirectory);
            }
            return driver;
        }

    }
}