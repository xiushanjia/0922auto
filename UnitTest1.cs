using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Xunit;

namespace OpenBaiduAuto
{
 
    public class UnitTest1
    {
        //private ScenarioContext context;

        //public UnitTest1(ScenarioContext context)
        //{
        //    this.Context = context;
        //}

        //public ScenarioContext Context { get => context; set => context = value; }

        //internal void CreateWebDriver(ScenarioContext context)
        //{
        //    // We are using Chrome, but you can use any driver
        //    var options = new ChromeOptions();
        //    options.AddArgument("--start-maximized");
        //    options.AddArgument("--disable-notifications");

        //    IWebDriver webDriver = new ChromeDriver(@"./");
        //}

        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
            //IWebDriver driver = this.Context.Get<IWebDriver>("WEB_DRIVER");

            //driver.Navigate().GoToUrl("https://www.baidu.com/");
            // 2 | setWindowSize | 1151x740 |  | 
            //driver.Manage().Window.Size = new System.Drawing.Size(1151, 740);
            //// 3 | type | id=kw | test | 
            //driver.FindElement(By.Id("kw")).SendKeys("test");
            //// 4 | click | id=su |  | 
            //driver.FindElement(By.Id("su")).Click();
            //// 5 | click | linkText=test - 百度翻译 |  | 
            //driver.FindElement(By.LinkText("test - 百度翻译")).Click();

        }
    }
}
