using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Skills
    {
        private static IWebElement SkillTab => Driver.driver.FindElement(By.XPath("//div/a[text()='Skills']"));
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement AddSkillTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement SkillLevelDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='level']"));
        private static IWebElement AddSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        internal void AddSkills(IWebDriver driver,string Skill, string SkillLevel)
        {
                SkillTab.Click();
                Wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
                AddButton.Click();
                AddSkillTextBox.SendKeys(Skill);
                SelectElement element = new SelectElement(SkillLevelDropdown);
                element.SelectByValue(SkillLevel);
                AddSkillButton.Click();
            
           
        }
        
    }
}
