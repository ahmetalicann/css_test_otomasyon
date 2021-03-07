using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace css_test_otomasyon
{
    public class Class1
    {
        IWebDriver driver = new ChromeDriver();
        public Class1()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            
        }
        public void urlGit()
        {
            driver.Navigate().GoToUrl("https://www.n11.com/");

        }

        public void search()
        {
            driver.FindElement(By.Id("searchData")).SendKeys("Spor ayakkabı" + OpenQA.Selenium.Keys.Enter);
        }

        public void pop_up()
        {
            try
            {
                driver.FindElement(By.ClassName("seg-popup-close")).Click();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        public void kvk()
        {
            try
            {
                driver.FindElement(By.CssSelector("div#userKvkkModal span.btnBlack")).Click();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            Console.WriteLine("Sayfa Başlığı" + driver.Title + "sayfa Url:" + driver.Url);
            var productPrice = driver.FindElement(By.CssSelector("div#newCheckout table:nth-child(6) div.priceArea span")).Text;
            var productPrice2 = driver.FindElement(By.CssSelector("div#newCheckout table:nth-child(5) div.priceArea span")).Text;
            Console.WriteLine("1. Ürünün Sepet Fiyatı:" + productPrice + " " + "2. Ürünün Sepet Fiyatı:" + productPrice2);
        }

        public void scrollDown()
        {
            var element = driver.FindElement(By.CssSelector("div#p-238339646 h3.productName"));
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", element);
        }

        public void product1()
        {
            driver.FindElement(By.CssSelector("div#p-449429646 h3.productName")).Click();
        }

        public void product2()
        {
            driver.FindElement(By.CssSelector("div#p-238339646 h3.productName")).Click();

        }

        public void productOptions1()
        {
            driver.FindElement(By.XPath(".//*[@id = '768877666']/option[2]")).Click();
            driver.FindElement(By.XPath(".//*[@id = '768877667']/option[2]")).Click();
        }

        public void addBasket()
        {
            driver.FindElement(By.ClassName("btnAddBasket")).Click();
            Thread.Sleep(1000);
        }

        public void basket()
        {
            driver.FindElement(By.ClassName("iconBasket")).Click();


        }

        public void Back()
        {
            driver.Navigate().Back();
        }

        public void productOptions2()
        {
            driver.FindElement(By.XPath(".//*[@id = '754652198']/option[2]")).Click();
            driver.FindElement(By.XPath(".//*[@id = '754652199']/option[2]")).Click();
        }

        public void buyButton()
        {
            driver.FindElement(By.Id("js-buyBtn")).Click();
        }

        public void login()
        {
            driver.FindElement(By.Id("email")).SendKeys("ahmetali.6117@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("fnm230596");
            driver.FindElement(By.Id("loginButton")).Click();
        }

        public void comparassion()
        {
            var priceText = driver.FindElement(By.CssSelector("div#p-449429646 ins")).Text;
            var priceText2 = driver.FindElement(By.CssSelector("#p-238339646 ins")).Text;
            Console.WriteLine("1. Ürünün Fiyatı:" + priceText + " " + "2. Ürünün Fiyatı:" + priceText2);
            
        }


    }
}
