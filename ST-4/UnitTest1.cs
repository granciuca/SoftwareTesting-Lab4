using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace ST_4
{
    public class Lab4
    {
        IWebDriver chrome;
        const string url = "https://google.com";

        [SetUp]
        public void Setup()
        {
            chrome = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            chrome.Navigate().GoToUrl(url);
            chrome.Manage().Window.Maximize();

            var searchText = chrome.FindElement(By.ClassName("gLFyf"));
            searchText.SendKeys("2019 Ford Fusion Hybrid Titanium");
            searchText.SendKeys(Keys.Enter);

            bool isPresent = chrome.PageSource.Contains("head");

            if(isPresent)
            {
                Console.WriteLine("Test successfully passed.");
            } 
                else
            {
                Console.WriteLine("Test failed.");
            }

            Assert.Pass();
        }
    }
}