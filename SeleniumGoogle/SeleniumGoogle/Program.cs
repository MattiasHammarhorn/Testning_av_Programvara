using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO 1. Skapa en main
// TODO 2. Hämta plugin
// TODO 3. Hitta sökfältet i Google
// TODO 4. Sök efter "Testautomatisering Stockhomlm"
// TODO 5. Hitta sök knappen, klicka på den
// TODO 6. Ta fram resultatstats och skriv ut dem
namespace SeleniumGoogle
{
    class Program
    {
        // Skapa en variabel som håller webdriver
        static IWebDriver driver;
        // Wait map
        static IWait<IWebDriver> wait;
        // Main fanns redan
        static void Main(string[] args)
        {
            // Ställ in driver till att använda Firefox
            driver = new FirefoxDriver();
            // Öppna google
            driver.Url = "https://www.google.com";
            // Ställ in WebDriverWait med drivern den ska använda och antalet sekunder den ska vänta
            wait = new WebDriverWait(driver, new TimeSpan(3000));
            // Hitta sökfältet genom id och skriv in "Testautomatisering Stockholm"
            driver.FindElement(By.Id("lst-ib")).SendKeys("Testautomatisering Stockholm");
            // Hitta sök knappen och klicka på den
            driver.FindElement(By.Id("_fZl")).Click();
            // Lägger in en sleep för att låta programmet ladda klart
            System.Threading.Thread.Sleep(3000);
            // Gör en variabel av resultStats
            var result = driver.FindElement(By.Id("resultStats"));
            // Skriv ut results innerText
            Console.WriteLine(result.Text);
        }
    }
}
