using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace css_test_otomasyon
{
    [TestClass]
    public class UnitTest2
    {
        Class1 cs = new Class1();

        [TestMethod]
        public void TestMethod1()
        {
            cs.urlGit("https://www.n11.com/");
            cs.kategori("//*[@id='contentMain']/div/nav/ul/li[6]/a", "//*[@id='contentMain']/div/nav/ul/li[6]/div/ul/li[2]/a");
            cs.buttonClick("ul#filter-list > li:nth-child(1)");
            cs.productOptions(".//*[@id = '772151561']/label[1]");
            cs.buttonClick("#addToBasket");
            cs.buttonClick("div#wrapper a.myBasket");
            cs.kvkk();
            cs.buttonClick("span#js-buyBtn");
            cs.login();
        }
    }
}
