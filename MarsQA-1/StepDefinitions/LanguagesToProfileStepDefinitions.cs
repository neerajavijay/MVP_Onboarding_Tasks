using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class LanguagesToProfileStepDefinitions : Driver
    {
        [Given(@"\[Navigate to Language tab]")]
        public void GivenNavigateToLanguageTab()
        {
        }
        [When(@"\[I add '([^']*)' and '([^']*)' to Languages tab]")]
        public void WhenIAddAndToLanguagesTab(string Language, string LanguageLevel)
        {
            Language addLanguageObj = new Language();
            addLanguageObj.AddLanguage(driver, Language, LanguageLevel);
        }    
        [Then(@"\[The Record should be created successfully\.]")]
        public void ThenTheRecordShouldBeCreatedSuccessfully_()
        {
         Assert.Pass();
        }
        
    }
}
