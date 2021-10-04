using log4net;
using log4net.Config;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Nunit_FaceBookProject.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;
        //Get Logger for fully qualified name for type of 'AlertTests' class
        private static readonly ILog log = LogManager.GetLogger(typeof(FaceBookTests));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = LogManager.GetRepository(Assembly.GetCallingAssembly());

        [SetUp]
        public void BrowserTest()
        {
            //BasicConfigurator.Configure();
            // Valid XML file with Log4Net Configurations
            var fileInfo = new FileInfo(@"log4net.config");

            // Configure default logging repository with Log4Net configurations
            XmlConfigurator.Configure(repository, fileInfo);
            log.Info("Configured");
            ChromeOptions options = new ChromeOptions();
            //notification is disabled once the browser is launched
            options.AddArgument("--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.facebook.com/";
            log.Debug("navigating to url");
            //Used to maximize the window
            driver.Manage().Window.Maximize();
            log.Info("Window is maximized");
        }

        [TearDown]
        public void TearDown()
        {
            //Used to close the opened session
            driver.Quit();
        }

        public static void TakeScreenShot()
        {
            ITakesScreenshot screenshot = driver as ITakesScreenshot;
            Screenshot screenshot1 = screenshot.GetScreenshot();
            screenshot1.SaveAsFile(@"C:\Users\vedhashni.v\source\repos\Nunit_FaceBookProject\Nunit_FaceBookProject\ScreenShots\FaceBookTest.png");
        }
    }
}
