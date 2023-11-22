using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace SmartCalcultor
{
    public class SmartCalculatorTests
    {

        private AndroidDriver<AndroidElement> driver;
        private AppiumOptions options;
        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";
        private const string appLocation = @"C:\Calc_ Smart Calculator_2.2.5_Apkpure.apk";

        [SetUp]
        public void Setup()
        {

            this.options = new AppiumOptions() { PlatformName = "Android" };
            options.AddAdditionalCapability("app", appLocation);

            this.driver = new AndroidDriver<AndroidElement>(new Uri(appiumServer), options);


        }

        [Test]
        public void AddTwoPositiveNumbers()
        {

            var blankField = driver.FindElementById("mobi.appplus.calculator.plus:id/scrollViewMain");
            blankField.Clear();

            var digitEight = driver.FindElementById("mobi.appplus.calculator.plus:id/btn8");
            digitEight.Click();

            var plusButton = driver.FindElementById("mobi.appplus.calculator.plus:id/btnAdd");
            plusButton.Click();

            var digitFive = driver.FindElementById("mobi.appplus.calculator.plus:id/btn5");
            digitFive.Click();

            var equalButton = driver.FindElementById("mobi.appplus.calculator.plus:id/btnEqual");
            equalButton.Click();

            var resultField = driver.FindElementByXPath("//android.widget.TextView[5]");
            
            Assert.That(resultField, Is.Not.Null);
            Assert.That(resultField.Text, Is.EqualTo("13"));


        }

        [Test]
        public void SubstractTwoPositiveNumbers()
        {

            var blankField = driver.FindElementById("mobi.appplus.calculator.plus:id/scrollViewMain");
            blankField.Clear();

            var digitTwo = driver.FindElementById("mobi.appplus.calculator.plus:id/btn2");
            digitTwo.Click();

            var minusButton = driver.FindElementById("mobi.appplus.calculator.plus:id/btnSub");
            minusButton.Click();

            var digitOne = driver.FindElementById("mobi.appplus.calculator.plus:id/btn1");
            digitOne.Click();

            var equalButton = driver.FindElementById("mobi.appplus.calculator.plus:id/btnEqual");
            equalButton.Click();

            var resultField = driver.FindElementByXPath("//android.widget.TextView[5]");

            Assert.That(resultField, Is.Not.Null);
            Assert.That(resultField.Text, Is.EqualTo("1"));


        }
    }
}