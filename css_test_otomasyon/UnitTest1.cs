using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace css_test_otomasyon
{
    [TestClass]
    public class UnitTest1
    {
        Class1 cs = new Class1();
        [TestMethod]
        public void TestMethod1()
        {
            cs.urlGit();
            cs.search();
            //cs.pop_up();
            cs.scrollDown();
            cs.product1();
            cs.productOptions1();
            cs.addBasket();
            cs.Back();
            cs.scrollDown();
            cs.comparassion();
            cs.product2();
            cs.productOptions2();
            cs.addBasket();
            cs.basket();
            cs.kvk();
            cs.buyButton();
            cs.login();

        }
    }
}
