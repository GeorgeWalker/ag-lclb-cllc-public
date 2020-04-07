﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using Xunit;

/*
Feature: Catering_request_relocation
    As a logged in business user
    I would like to request a catering relocation

Scenario: Request Catering Relocation
    Given the Catering application has been approved
    And I am logged in to the dashboard as a private corporation
    And I click on the Licences tab
    And the licence fee has been paid
    And I click on the Request Relocation link
    And I review the account profile
    And I submit a licence relocation application
    And I complete the payment
    And I return to the dashboard
    Then a relocation request under review is displayed
*/

namespace bdd_tests
{
    [FeatureFile("./Catering_request_relocation.feature")]
    public sealed class CateringLicenceRequestRelocation : TestBase
    {
        [Given(@"the Catering application has been approved")]
        public void catering_application_approved()
        {
        }

        [And(@"I am logged in to the dashboard as a (.*)")]
        public void And_I_view_the_dashboard(string businessType)
        {
            CarlaLogin(businessType);
        }

        [And(@"I click on the Licences tab")]
        public void click_on_licences_tab()
        {
            /* 
            Page Title: Welcome to Liquor and Cannabis Licensing
            */

            string licencesLink = "Licences";

            // click on the Licences link
            NgWebElement uiLicences = ngDriver.FindElement(By.LinkText(licencesLink));
            uiLicences.Click();
        }

        [And(@"the licence fee has been paid")]
        public void licence_fee_paid()
        {
            /* 
            Page Title: 
            */
        }

        [And(@"I click on the Request Relocation link")]
        public void click_on_request_relocation()
        {
            /* 
            Page Title: 
            */
        }

        [And(@"I review the account profile")]
        public void review_account_profile()
        {
            /* 
            Page Title: 
            */
        }

        [And(@"I submit a licence relocation application")]
        public void submit_relocation_application()
        {
            /* 
            Page Title: 
            */
        }

        [And(@"I complete the payment")]
        public void make_payment()
        {
            /* 
            Page Title: 
            */

            MakePayment();
        }

        [And(@"I return to the dashboard")]
        public void return_to_dashboard()
        {
            /* 
            Page Title: Payment Approved
            */

            string retDash = "Return to Dashboard";

            // click on the Return to Dashboard link
            NgWebElement returnDash = ngDriver.FindElement(By.LinkText(retDash));
            returnDash.Click();
        }

        [Then(@"a relocation request under review is displayed")]
        public void relocation_request_displayed()
        {
            /* 
            Page Title: 
            */
        }

    }
}