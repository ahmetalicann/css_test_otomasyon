using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace css_test_otomasyon
{
    [TestClass]
    public class UnitTest3
    {
        Class1 cs = new Class1();
        [TestMethod]
        public void TestMethod1()
        {
            cs.urlGit("https://www.n11.com/");
            cs.search();
            cs.scrollDown();
            cs.buttonClick("#brand-klm-Kadın");
            cs.buttonClick("#brand-numara-38");
            cs.buttonClick("#p-390053319 .productName");
            cs.productOptions(".//*[@id = '743015531']/option[3]");
            cs.buttonClick("div#contentProDetail a.btnAddBasket");
            cs.buttonClick("div#wrapper a.myBasket");
            cs.kvkk();
            cs.buttonClick("span#js-buyBtn");
            cs.login();
        }
    }
}
