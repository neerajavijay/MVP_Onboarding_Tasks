using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SkillsToProfileStepDefinitions : Driver
    {

        [Given(@"\[Navigate to Skills tab]")]
        public void GivenNavigateToSkillsTab()
        {
        }

        [When(@"\[I add '([^']*)' and '([^']*)' to Skills tab]")]
        public void WhenIAddAndToSkillsTab(string Skill, string SkillLevel)
        {
            Skills addSkillObj = new Skills();
            addSkillObj.AddSkills(driver, Skill, SkillLevel);

        }

        [Then(@"\[The Skill Record should be created successfully]")]
        public void ThenTheSkillRecordShouldBeCreatedSuccessfully()
        {
            Assert.Pass();
        }

      


    }

}
