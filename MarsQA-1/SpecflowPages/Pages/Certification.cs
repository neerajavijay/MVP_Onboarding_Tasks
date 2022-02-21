﻿using MarsQA_1.Helpers;
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
    class Certification
    {
        private static IWebElement CertificationTab => Driver.driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[4]"));
        private static IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement AddCertificateTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
        private static IWebElement AddCertifiedFromTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
        private static IWebElement YearDropDown => Driver.driver.FindElement(By.XPath(".//*[@name='certificationYear']"));
        private static IWebElement AddCertificationButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
       
        public void AddCertification(string Certificate, string CertifiedFrom, string Year)
        {
            
                CertificationTab.Click();
                AddNewButton.Click();
                AddCertificateTextBox.SendKeys(Certificate);
                AddCertifiedFromTextBox.SendKeys(CertifiedFrom);
                SelectElement element3 = new SelectElement(YearDropDown);
                element3.SelectByValue(Year);
                AddCertificationButton.Click();
        }

        

    }
}
