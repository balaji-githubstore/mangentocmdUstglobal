using System;
using MagentoGit.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MagentoGit
{
    public class MagentoTest
    {
//done by balaji
        [Test, Parallelizable]
        public void ValidCredential1()
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver(@"D:\Mine\Company\Maveric\Driver");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Url = "https://magento.com/";

                //HomePage
                HomePage homePage = new HomePage(driver);
                homePage.ClickOnMyAccount();

                //LoginPage
                LoginPage loginPage = new LoginPage(driver);
                loginPage.SetUserName("balajidinakaran1@gmail.com");
                loginPage.SetPassword("Welcome123");
                loginPage.ClickOnLogin();

                //MainPage
                MainPage mainPage = new MainPage(driver);
                //Thread.Sleep(5000);
                //String title= mainPage.getTitle();
                //Assert.AreEqual("My Account", title);
                mainPage.ClickonLogOut();
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message" + ex);

                Screenshot s = ((ITakesScreenshot)driver).GetScreenshot();
                s.SaveAsFile("error.png");

                Assert.Fail();
            }
        }
        [Test, Parallelizable]
        public void ValidCredential2()
        {
            IWebDriver driver = null;
            try
            {
                driver = new FirefoxDriver(@"D:\Mine\Company\Maveric\Driver");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                driver.Url = "https://magento.com/";

                //HomePage
                HomePage homePage = new HomePage(driver);
                homePage.ClickOnMyAccount();

                //LoginPage
                LoginPage loginPage = new LoginPage(driver);
                loginPage.SetUserName("balaji0017@gmail.com");
                loginPage.SetPassword("Welcome123");
                loginPage.ClickOnLogin();

                //MainPage
                MainPage mainPage = new MainPage(driver);
                //Thread.Sleep(5000);
                //String title = mainPage.getTitle();
                //Assert.AreEqual("My Account", title);
                mainPage.ClickonLogOut();
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message" + ex);

                Screenshot s = ((ITakesScreenshot)driver).GetScreenshot();
                s.SaveAsFile(@"D:\Mine\Company\UST-Global_Net\CSharp\MagentoAutomation\MagentoAutomation\error.png");

                Assert.Fail();
            }


        }
        [Test, Parallelizable]
        public void ValidCredential3()
        {
            Assert.Fail();
        }
    }
}
