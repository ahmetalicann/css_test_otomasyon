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
            cs.urlGit("https://www.n11.com/");
            cs.search();
            //cs.pop_up();
            cs.scrollDown();
            cs.buttonClick("div#p-449429646 h3.productName");
            cs.productOptions(".//*[@id = '768877666']/option[2]");
            cs.productOptions(".//*[@id = '768877667']/option[2]");
            cs.buttonClick("div#contentProDetail a.btnAddBasket");
            cs.Back();
            cs.scrollDown();
            cs.buttonClick("div#p-238339646 h3.productName");
            cs.productOptions(".//*[@id = '754652198']/option[2]");
            cs.productOptions(".//*[@id = '754652199']/option[2]");
            cs.buttonClick("div#contentProDetail a.btnAddBasket");
            cs.buttonClick("div#wrapper a.myBasket");
            cs.kvkk();
            cs.buttonClick("span#js-buyBtn");
            cs.login();

        }
    }
}
