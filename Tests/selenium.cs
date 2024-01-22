using NUnit.Framework;
using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Tests
{
    internal class selenium
       
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ma-calculatrice.fr/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1500);
            Console.WriteLine("Welcome to the web site");
        }
        [TearDown]
        public void Clean()
        {
            driver.Close();
            Console.WriteLine("Web site Closed");
        }
        [OneTimeTearDown]
        public void Quit()
        {
            driver.Quit();
           
        }
        /********************  Testing The Addition Operation  ********************/
        [Test]
        public void FirstSeleniumAdditionTest()
        {
            

            var number1 = driver.FindElement(By.Id("un"));
            var number2 = driver.FindElement(By.Id("deux"));
            var plus = driver.FindElement(By.Id("addition"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));

       


            number1.Click();
            Task.Delay(100);
            plus.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            // Retrieve the actual result value
            string actualResult = res.Text;
            

            // Assert that the actual result is equal to the expected value "3"
            Assert.That(actualResult, Is.EqualTo("3"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }
        [Test]
        public void SecondSeleniumAdditionTest()
        {


            var number1 = driver.FindElement(By.Id("deux"));
            var number2 = driver.FindElement(By.Id("trois"));
            var plus = driver.FindElement(By.Id("addition"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));



            number1.Click();
            Task.Delay(100);
            plus.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            // Retrieve the actual result value
            string actualResult = res.Text;


            // Assert that the actual result is equal to the expected value "5"
            Assert.That(actualResult, Is.EqualTo("5"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }
        /********************  Testing The Multiplication Operation  ********************/
        [Test]
        public void ThirdSeleniumMultiplicationTest()
        {


            var number1 = driver.FindElement(By.Id("deux"));
            var number2 = driver.FindElement(By.Id("trois"));
            var multiplicate = driver.FindElement(By.Id("multiplier"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));

     


            number1.Click();
            Task.Delay(100);
            multiplicate.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            // Retrieve the actual result value
            string actualResult = res.Text;


            // Assert that the actual result is equal to the expected value "6"
            Assert.That(actualResult, Is.EqualTo("6"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }
        public void FourthSeleniumMultiplicationTest()
        {


            var number1 = driver.FindElement(By.Id("deux"));
            var number2 = driver.FindElement(By.Id("deux"));
            var multiplicate = driver.FindElement(By.Id("multiplier"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));




            number1.Click();
            Task.Delay(100);
            multiplicate.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            // Retrieve the actual result value
            string actualResult = res.Text;


            // Assert that the actual result is equal to the expected value "4"
            Assert.That(actualResult, Is.EqualTo("4"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }
        /********************  Testing The Division Operation  ********************/
        [Test]
        public void FifthSeleniumDivisionTest()
        {


            var number1 = driver.FindElement(By.Id("deux"));
            var number2 = driver.FindElement(By.Id("un"));
            var div = driver.FindElement(By.Id("diviser"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));


            number1.Click();
            Task.Delay(100);
            div.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            // Retrieve the actual result value
            string actualResult = res.Text;


            // Assert that the actual result is equal to the expected value "2"
            Assert.That(actualResult, Is.EqualTo("2"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }
        [Test]
        public void SixthSeleniumDivisionTest()
        {


            var number1 = driver.FindElement(By.Id("deux"));
            var number2 = driver.FindElement(By.Id("deux"));
            var div = driver.FindElement(By.Id("diviser"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));


            number1.Click();
            Task.Delay(100);
            div.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            // Retrieve the actual result value
            string actualResult = res.Text;


            // Assert that the actual result is equal to the expected value "1"
            Assert.That(actualResult, Is.EqualTo("1"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }
        /********************  Testing The Substraction Operation  ********************/
        [Test]
        public void SeventhSeleniumMoinsTest()
        {


            var number1 = driver.FindElement(By.Id("deux"));
            var number2 = driver.FindElement(By.Id("un"));
            var moins = driver.FindElement(By.Id("moins"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));


            number1.Click();
            Task.Delay(100);
            moins.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            // Retrieve the actual result value
            string actualResult = res.Text;


            // Assert that the actual result is equal to the expected value "1"
            Assert.That(actualResult, Is.EqualTo("1"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }
        [Test]
        public void EighthSeleniumMoinsTest()
        {


            var number1 = driver.FindElement(By.Id("trois"));
            var number2 = driver.FindElement(By.Id("deux"));
            var moins = driver.FindElement(By.Id("moins"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));


            number1.Click();
            Task.Delay(100);
            moins.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            // Retrieve the actual result value
            string actualResult = res.Text;


            // Assert that the actual result is equal to the expected value "1"
            Assert.That(actualResult, Is.EqualTo("1"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }

    }
}
