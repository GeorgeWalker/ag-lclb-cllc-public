﻿using System;
using OpenQA.Selenium;
using Xunit.Gherkin.Quick;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [And(@"I complete the Agent Licence application for a (.*)")]
        public void CompleteAgentLicence(string bizType)
        {
            /* 
            Page Title: Agent Licence Application
            */

            var contactPhone = "2501811818";
            var contactEmail = "test@automation.com";

            if (bizType == "partnership")
            {
                // upload a partnership agreement
                FileUpload("partnership_agreement.pdf", "(//input[@type='file'])[3]");

                // upload personal history summary
                FileUpload("personal_history_summary.pdf", "(//input[@type='file'])[6]");
            }

            if (bizType == "public corporation")
            {
                // upload notice of articles
                FileUpload("notice_of_articles.pdf", "(//input[@type='file'])[3]");

                // upload personal history summary documents
                FileUpload("personal_history_summary.pdf", "(//input[@type='file'])[6]");
            }

            if (bizType == "private corporation")
            {
                // upload a central securities register
                FileUpload("central_securities_register.pdf", "(//input[@type='file'])[3]");

                // upload supporting business documentation
                FileUpload("associates.pdf", "(//input[@type='file'])[6]");

                // upload notice of articles
                FileUpload("notice_of_articles.pdf", "(//input[@type='file'])[9]");

                // upload personal history summary documents
                FileUpload("personal_history_summary.pdf", "(//input[@type='file'])[12]");

                // upload shareholders < 10% interest
                FileUpload("shareholders_less_10_interest.pdf", "(//input[@type='file'])[15]");
            }

            if (bizType == "society")
            {
                // upload notice of articles
                FileUpload("notice_of_articles.pdf", "(//input[@type='file'])[3]");

                // upload personal history summary documents
                FileUpload("personal_history_summary.pdf", "(//input[@type='file'])[6]");
            }

            if (bizType == "sole proprietorship")
                // upload personal history summary documents
                FileUpload("personal_history_summary.pdf", "(//input[@type='file'])[3]");



            // enter the contact phone number
            var uiContactPhone = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactPersonPhone']"));
            uiContactPhone.SendKeys(contactPhone);

            // enter the contact email
            var uiContactEmail = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactPersonEmail']"));
            uiContactEmail.SendKeys(contactEmail);

            // click on the authorized to submit checkbox
            var uiAuthorizedToSubmit = ngDriver.FindElement(By.Id("authorizedToSubmit"));
            uiAuthorizedToSubmit.Click();

            // click on the signature agreement checkbox
            var uiSignatureAgreement = ngDriver.FindElement(By.Id("signatureAgreement"));
            uiSignatureAgreement.Click();

            // retrieve the current URL to get the application ID (needed downstream)
            var URL = ngDriver.Url;

            // retrieve the application ID
            var parsedURL = URL.Split('/');

            var tempFix = parsedURL[5].Split(';');

            applicationID = tempFix[0];
        }
    }
}