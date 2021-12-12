using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;



namespace HT2_Test
{
    public class Tests
    {

        private IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://google.com");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            IWebElement inputSearch = driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']"));
            inputSearch.SendKeys( "розетка уа"+ OpenQA.Selenium.Keys.Enter);
            driver.FindElement(By.XPath("//a[@href='https://rozetka.com.ua/']")).Click();
            driver.FindElement(By.XPath("//a[@class = 'menu-categories__link'][@href='https://rozetka.com.ua/computers-notebooks/c80253/']"))
                  .Click();
            driver.FindElement(By.XPath("//a[@href='https://rozetka.com.ua/notebooks/c80004/'][2]")).Click();
            driver.FindElement(By.XPath("//div[@data-filter-name='producer']//ul//li//a[contains(@href, 'dell')]")).Click();
            driver.FindElement(By.CssSelector("rz-sort select")).Click();
            driver.FindElement(By.CssSelector("rz-sort select option:nth-child(3)")).Click();
            driver.FindElement(By.CssSelector("rz-sort select")).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//div/section/rz-grid/ul/li[1]//button[@aria-label='Купить']")).Click();
            driver.FindElement(By.CssSelector("a.header__logo")).Click();
            driver.FindElement(By.XPath("//a[@class = 'menu-categories__link'][contains(@href, 'telefony-tv-i-ehlektronika/c4627949/')]")).Click();
            driver.FindElement(By.XPath("//a[contains(@class, 'tile-cats__heading tile-cats__')][contains(@href, 'mobile-phones')]")).Click();
            driver.FindElement(By.CssSelector("rz-filter-section-autocomplete ul li:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector("rz-sort select")).Click();
            driver.FindElement(By.CssSelector("rz-sort select option:nth-child(3)")).Click();
            driver.FindElement(By.CssSelector("rz-sort select")).Click();
            driver.FindElement(By.XPath("//div/section/rz-grid/ul/li[1]//button[@aria-label='Купить']")).Click();
            driver.FindElement(By.CssSelector("a.header__logo")).Click();
            driver.FindElement(By.XPath("//a[@class = 'menu-categories__link'][contains(@href, 'game-zone/c80261/')]")).Click();
            driver.FindElement(By.XPath("//a[contains(@class, 'tile-cats__heading tile-cats__')][contains(@href, '/consoles/c80020/')]")).Click();
            driver.FindElement(By.CssSelector("rz-filter-section-autocomplete ul li:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector("rz-sort select")).Click();
            driver.FindElement(By.CssSelector("rz-sort select option:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector("rz-sort select")).Click();
            driver.FindElement(By.XPath("//div/section/rz-grid/ul/li[1]//button[@aria-label='Купить']")).Click();
            string amount = driver.FindElement(By.XPath("//span[@class='counter counter--green ng-star-inserted']")).Text;
            //string expected = "3";
            Assert.AreEqual("1", amount);
            driver.FindElement(By.CssSelector("ul li rz-cart button")).Click();
            string a = driver.FindElement(By.XPath("//div[@class='cart - receipt__sum - price']/span[1]")).Text;
            int sum = int.Parse(a);
            int expsum = 150000;
            Assert.AreEqual(expsum, sum);

        }

        public void TearDown()
        {
            driver.Quit();
        }
    }
}