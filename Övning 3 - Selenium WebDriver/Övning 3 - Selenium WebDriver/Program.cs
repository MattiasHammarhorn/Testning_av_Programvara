using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Threading;
// TODO a. Skapa en Webdriver
// TODO b. Gå till Lyko.se
// TODO c. Sök efter "Schampoo" i sökfältet
// TODO d. Tryck på en Schampoo produkt, lägg i varukorgen
// TODO e. Gå till checkout i övre högra hörnet
// TODO f. Gå till kassan
// TODO g. Öka antalet av produkten till 10
// TODO h. Verifiera att Lyko loggan finns
// TODO i. Tryck på Lyko loggan

namespace Övning_3___Selenium_WebDriver
{
    class Program
    {
        static IWebDriver driver;
        static IWait<IWebDriver> wait;

        static void Main(string[] args)
        {
            // Ställ in driver till att använda Firefox
            driver = new FirefoxDriver();
            // Öppna Lyko
            driver.Url = "https://www.lyko.se";
            // Sätt dit en wait som väntar i 3 sekunder
            wait = new WebDriverWait(driver, new TimeSpan(3000));
            // Hitta elementet för sökfältet och skicka in "Schampoo"
            driver.FindElement(By.Name("q")).SendKeys("Schampoo");
            
            // Sätt dit en sleep som väntar i 3 sekunder
            Thread.Sleep(3000);

            // Hitta elementet för den första produkten och klicka på den
            driver.FindElement(By.ClassName("_1VWR48")).Click();

            Thread.Sleep(3000);

            // Hitta elementet för köp knappen och klicka på den
            driver.FindElement(By.XPath("//button[@class = '_2JULYU _2wqSrG']")).Click();

            Thread.Sleep(3000);

            // Hitta button klassen för varukorgen genom XPath
            driver.FindElement(By.XPath("//button[@class = '_1w9fSZ _2nA9po _2mJsVq']")).Click();

            Thread.Sleep(3000);

            // Hitta elementet för href som leder till kassan och klicka på den
            driver.FindElement(By.CssSelector("[href *= '/kassa']")).Click();

            // Hitta 'Öka antal' knappen genom XPath och klicka på den
            // medans for-loopen iterar sig tills villkoret möts
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(1500);
                driver.FindElement(By.XPath("//button[@title='Öka antal']")).Click();
            }

            object cover = null;

            try
            {
                cover = driver.FindElement(By.XPath("//a[@class = 'jmb20U _3Xzqlr']"));
                Console.WriteLine("Loggan finns!");
            }

            catch (ArgumentException e)
            {
                Console.WriteLine("Loggan finns ej!");
                throw e;
            }

            Thread.Sleep(3000);
            // Hitta elementet för Lyko loggan och klicka på den
            driver.FindElement(By.XPath("//a[@class = 'jmb20U _3Xzqlr']")).Click();
        }
    }
}
