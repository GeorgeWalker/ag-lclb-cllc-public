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
Feature: CateringApplication_pubcorp
    As a logged in business user
    I want to submit a Catering Application for a public corporation

Scenario: Start Application
    Given I am logged in to the dashboard as a public corporation
    And I click on the Catering Start Application button
    And I review the account profile
    And I review the organization structure
    And I complete the application
    And I click on the Submit button
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./CateringApplication_pubcorp.feature")]
    public sealed class CateringApplicationPublicCorp : TestBaseCatering
    {
        [Given(@"I am logged in to the dashboard as a (.*)")]
        public void I_view_the_dashboard(string businessType)
        {
            CarlaLogin(businessType);
        }

        [And(@"I click on the Catering Start Application button")]
        public void I_start_application()
        {
            /* 
            Page Title: 
            */

            // click on the Catering Start Application button
            NgWebElement startApp_button = ngDriver.FindElement(By.Id("startCatering"));
            startApp_button.Click();
        }

        [And(@"I review the account profile")]
        public void review_account_profile()
        {
            /* 
            Page Title: Please Review the Account Profile
            */

            string bizNumber = "012345678";
            string incorporationNumber = "BC1234567";

            string physStreetAddress1 = "645 Tyee Road";
            string physStreetAddress2 = "West of Victoria";
            string physCity = "Victoria";
            string physPostalCode = "V8V4Y3";

            string mailStreet1 = "P.O. Box 123";
            string mailStreet2 = "303 Prideaux St.";
            string mailCity = "Nanaimo";
            string mailProvince = "B.C.";
            string mailPostalCode = "V9R2N3";
            string mailCountry = "Switzerland";

            string bizPhoneNumber = "2501811818";
            string bizEmail = "test@automation.com";
            string corpGiven = "CateringPubCorpGiven";
            string corpSurname = "CateringPubCorpSurname";
            string corpTitle = "CEO";
            string corpContactPhone = "7781811818";
            string corpContactEmail = "automated@test.com";

            // enter the Business Number
            NgWebElement uiBizNumber = ngDriver.FindElement(By.XPath("(//input[@type='text'])[3]"));
            uiBizNumber.SendKeys(bizNumber);

            // enter the Incorporation Number
            NgWebElement uiCorpNumber = ngDriver.FindElement(By.Id("bcIncorporationNumber"));
            uiCorpNumber.SendKeys(incorporationNumber);

            // enter the Date of Incorporation in B.C. 
            NgWebElement uiCalendar1 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[5]"));
            uiCalendar1.Click();

            NgWebElement uiCalendar2 = ngDriver.FindElement(By.XPath("//mat-calendar[@id='mat-datepicker-0']/div/mat-month-view/table/tbody/tr[2]/td[2]/div"));
            uiCalendar2.Click();

            // enter the physical street address 1
            NgWebElement uiPhysStreetAddress1 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[6]"));
            uiPhysStreetAddress1.SendKeys(physStreetAddress1);

            // enter the physical street address 2
            NgWebElement uiPhysStreetAddress2 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[7]"));
            uiPhysStreetAddress2.SendKeys(physStreetAddress2);

            // enter the physical city
            NgWebElement uiPhysCity = ngDriver.FindElement(By.XPath("(//input[@type='text'])[8]"));
            uiPhysCity.SendKeys(physCity);

            // enter the physical postal code
            NgWebElement uiPhysPostalCode = ngDriver.FindElement(By.XPath("(//input[@type='text'])[10]"));
            uiPhysPostalCode.SendKeys(physPostalCode);

            /* switching off use of checkbox "Same as physical address" in order to test mailing address fields
            NgWebElement uiSameAsMailingAddress = ngDriver.FindElement(By.XPath("//input[@type='checkbox']"));
            uiSameAsMailingAddress.Click(); */

            // enter the mailing street address 1
            NgWebElement uiMailingStreetAddress1 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[12]"));
            uiMailingStreetAddress1.SendKeys(mailStreet1);

            // enter the mailing street address 2
            NgWebElement uiMailingStreetAddress2 = ngDriver.FindElement(By.XPath("(//input[@type='text'])[13]"));
            uiMailingStreetAddress2.SendKeys(mailStreet2);

            // enter the mailing city
            NgWebElement uiMailingCity = ngDriver.FindElement(By.XPath("(//input[@type='text'])[14]"));
            uiMailingCity.SendKeys(mailCity);

            // enter the mailing province
            NgWebElement uiMailingProvince = ngDriver.FindElement(By.XPath("(//input[@type='text'])[15]"));
            uiMailingProvince.SendKeys(mailProvince);

            // enter the mailing postal code
            NgWebElement uiMailingPostalCode = ngDriver.FindElement(By.XPath("(//input[@type='text'])[16]"));
            uiMailingPostalCode.SendKeys(mailPostalCode);

            // enter the mailing country
            NgWebElement uiMailingCountry = ngDriver.FindElement(By.XPath("(//input[@type='text'])[17]"));
            uiMailingCountry.SendKeys(mailCountry);

            // enter the business phone number
            NgWebElement uiBizPhoneNumber = ngDriver.FindElement(By.XPath("(//input[@type='text'])[18]"));
            uiBizPhoneNumber.SendKeys(bizPhoneNumber);

            // enter the business email
            NgWebElement uiBizEmail = ngDriver.FindElement(By.XPath("(//input[@type='text'])[19]"));
            uiBizEmail.SendKeys(bizEmail);

            // (re)enter the first name of corporation contact
            NgWebElement uiCorpGiven = ngDriver.FindElement(By.XPath("(//input[@type='text'])[20]"));
            uiCorpGiven.SendKeys(corpGiven);

            // (re)enter the last name of corporation contact
            NgWebElement uiCorpSurname = ngDriver.FindElement(By.XPath("(//input[@type='text'])[21]"));
            uiCorpSurname.SendKeys(corpSurname);

            // enter the corporation contact title
            NgWebElement uiCorpTitle = ngDriver.FindElement(By.XPath("(//input[@type='text'])[22]"));
            uiCorpTitle.SendKeys(corpTitle);

            // enter the corporation contact phone number
            NgWebElement uiCorpContactPhone = ngDriver.FindElement(By.XPath("(//input[@type='text'])[23]"));
            uiCorpContactPhone.SendKeys(corpContactPhone);

            // enter the corporation contact phone email
            NgWebElement uiCorpContactEmail = ngDriver.FindElement(By.XPath("(//input[@type='text'])[24]"));
            uiCorpContactEmail.SendKeys(corpContactEmail);

            // select 'No' for corporation's connection to a federal producer
            NgWebElement corpConnectionFederalProducer = ngDriver.FindElement(By.XPath("(//input[@type='radio'])[2]"));
            corpConnectionFederalProducer.Click();

            // select 'No' for federal producer's connection to corporation
            NgWebElement federalProducerConnectionToCorp = ngDriver.FindElement(By.XPath("(//input[@type='radio'])[4]"));
            federalProducerConnectionToCorp.Click();

            // click on Continue to Organization Review button
            NgWebElement continueApp_button = ngDriver.FindElement(By.Id("continueToApp"));
            continueApp_button.Click();
        }

        [And(@"I review the organization structure")]
        public void I_continue_to_organization_review()
        {
            /* 
            Page Title: [client name] Detailed Organization Information
            */

            // find the upload test file in the bdd-tests\upload_files folder
            var environment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            // upload NOA form
            string NOAPath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "signage.pdf");
            NgWebElement uploadNOA = ngDriver.FindElement(By.XPath("(//input[@type='file'])[2]"));
            uploadNOA.SendKeys(NOAPath);

            /********** Key Personnel **********/

            // create the key personnel data
            string keyPersonnelFirst = "Jane";
            string keyPersonnelLast = "Bond";
            string keyPersonnelTitle = "Adventurer";
            string keyPersonnelEmail = "jane@bond.com";

            // open key personnel form
            NgWebElement openKeyPersonnelForm = ngDriver.FindElement(By.XPath("//div[@id='cdk-step-content-0-1']/app-application-licensee-changes/div/section/app-org-structure/div[3]/section/app-associate-list/div/button"));
            openKeyPersonnelForm.Click();

            // enter key personnel first name
            NgWebElement openKeyPersonnelFirst = ngDriver.FindElement(By.XPath("//input[@type='text']"));
            openKeyPersonnelFirst.SendKeys(keyPersonnelFirst);

            // enter key personnel last name
            NgWebElement openKeyPersonnelLast = ngDriver.FindElement(By.XPath("(//input[@type='text'])[2]"));
            openKeyPersonnelLast.SendKeys(keyPersonnelLast);

            // select key personnel role
            NgWebElement openKeyPersonnelRole = ngDriver.FindElement(By.XPath("//input[@type='checkbox']"));
            openKeyPersonnelRole.Click();

            // enter key personnel title
            NgWebElement openKeyPersonnelTitle = ngDriver.FindElement(By.XPath("(//input[@type='text'])[3]"));
            openKeyPersonnelTitle.SendKeys(keyPersonnelTitle);

            // enter key personnel email
            NgWebElement openKeyPersonnelEmail = ngDriver.FindElement(By.XPath("(//input[@type='text'])[4]"));
            openKeyPersonnelEmail.SendKeys(keyPersonnelEmail);

            // select key person DOB
            NgWebElement openKeyPersonnelDOB = ngDriver.FindElement(By.XPath("(//input[@type='text'])[5]"));
            openKeyPersonnelDOB.Click();

            NgWebElement openKeyPersonnelDOB1 = ngDriver.FindElement(By.XPath("//mat-calendar[@id='mat-datepicker-1']/div/mat-month-view/table/tbody/tr[2]/td[2]/div"));
            openKeyPersonnelDOB1.Click();

            // click on Submit Organization Info button
            NgWebElement submitOrgInfoButton = ngDriver.FindElement(By.XPath("//button[contains(.,'SUBMIT ORGANIZATION INFORMATION')]"));
            submitOrgInfoButton.Click();
        }


        [And(@"I complete the application")]
        public void I_complete_the_application()
        {
            /* 
            Page Title: [none]
            */

            // create application info
            string estName = "Point Ellis Greenhouse";
            string estAddress = "645 Tyee Rd";
            string estCity = "Victoria";
            string estPostal = "V9A6X5";
            string estPID = "012345678";
            string estPhone = "2505555555";
            string conGiven = "Given";
            string conSurname = "Surname";
            string conRole = "CEO";
            string conPhone = "2508888888";

            // enter the establishment name
            NgWebElement estabName = ngDriver.FindElement(By.Id("establishmentName"));
            estabName.SendKeys(estName);

            // select 'No' for previous liquor licence
            NgWebElement previousLicence = ngDriver.FindElement(By.Id("mat-button-toggle-2-button"));
            previousLicence.Click();

            // select 'No' for Rural Agency Store Appointment
            NgWebElement ruralStore = ngDriver.FindElement(By.Id("mat-button-toggle-5-button"));
            ruralStore.Click();

            // select 'No' for distillery, brewery or winery connections
            NgWebElement liquorProduction = ngDriver.FindElement(By.Id("mat-button-toggle-8-button"));
            liquorProduction.Click();

            // enter the establishment address
            NgWebElement estabAddress = ngDriver.FindElement(By.Id("establishmentAddressStreet"));
            estabAddress.SendKeys(estAddress);

            // enter the establishment city
            NgWebElement estabCity = ngDriver.FindElement(By.Id("establishmentAddressCity"));
            estabCity.SendKeys(estCity);

            // enter the establishment postal code
            NgWebElement estabPostal = ngDriver.FindElement(By.Id("establishmentAddressPostalCode"));
            estabPostal.SendKeys(estPostal);

            // enter the PID
            NgWebElement estabPID = ngDriver.FindElement(By.Id("establishmentParcelId"));
            estabPID.SendKeys(estPID);

            // enter the store phone number
            NgWebElement estabPhone = ngDriver.FindElement(By.Id("establishmentPhone"));
            estabPhone.SendKeys(estPhone);

            // select 'No' for other business on premises
            NgWebElement otherBusiness = ngDriver.FindElement(By.Id("mat-button-toggle-11-button"));
            otherBusiness.Click();

            // find the upload test files in the bdd-tests\upload_files folder
            var environment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(environment).Parent.FullName;
            string projectDirectory2 = Directory.GetParent(projectDirectory).Parent.FullName;

            // upload a store signage document
            string signagePath = Path.Combine(projectDirectory2 + Path.DirectorySeparatorChar + "bdd-tests" + Path.DirectorySeparatorChar + "upload_files" + Path.DirectorySeparatorChar + "signage.pdf");
            NgWebElement uploadSignage = ngDriver.FindElement(By.XPath("(//input[@type='file'])[2]"));
            uploadSignage.SendKeys(signagePath);

            // enter the first name of the application contact
            NgWebElement contactGiven = ngDriver.FindElement(By.Id("contactPersonFirstName"));
            contactGiven.SendKeys(conGiven);

            // enter the last name of the application contact
            NgWebElement contactSurname = ngDriver.FindElement(By.Id("contactPersonLastName"));
            contactSurname.SendKeys(conSurname);

            // enter the role of the application contact
            NgWebElement contactRole = ngDriver.FindElement(By.Id("contactPersonRole"));
            contactRole.SendKeys(conRole);

            // enter the phone number of the application contact
            NgWebElement contactPhone = ngDriver.FindElement(By.Id("contactPersonPhone"));
            contactPhone.SendKeys(conPhone);

            // click on the authorized to submit checkbox
            NgWebElement authorizedSubmit = ngDriver.FindElement(By.Id("authorizedToSubmit"));
            authorizedSubmit.Click();

            // click on the signature agreement checkbox
            NgWebElement signatureAgree = ngDriver.FindElement(By.Id("signatureAgreement"));
            signatureAgree.Click();
        }

        [And(@"I click on the Submit button")]
        public void click_on_submit()
        {
            NgWebElement submit_button = ngDriver.FindElement(By.XPath("//button[contains(.,'SUBMIT')]"));
            submit_button.Click();
        }

        [And(@"I click on the Pay for Application button")]
        public void click_on_pay()
        {
            NgWebElement pay_button = ngDriver.FindElement(By.XPath("//button[contains(.,'Pay for Application')]"));
            pay_button.Click();
        }

        [And(@"I enter the payment information")]
        public void enter_payment_info()
        {
            MakeCateringPayment();
        }

        [And(@"I return to the dashboard")]
        public void return_to_dashboard()
        {
            /* 
            Page Title: Payment Approved
            */

            // confirm that payment receipt is for $475.00
            Assert.True(ngDriver.FindElement(By.XPath("/html/body/app-root/div/div/div/main/div/app-payment-confirmation/mat-card/div/div[1]/div/div/table/tr[6]/td[2][text()='$475.00']")).Displayed);

            string retDash = "Return to Dashboard";

            // click on the Return to Dashboard link
            NgWebElement returnDash = ngDriver.FindElement(By.LinkText(retDash));
            returnDash.Click();
        }

        [And(@"the account is deleted")]
        public void Delete_my_account()
        {
            this.CarlaDeleteCurrentAccount();
        }

        [Then(@"I see the login page")]
        public void I_see_login()
        {
            /* 
            Page Title: 
            */

            Assert.True(ngDriver.FindElement(By.XPath("//a[text()='Log In']")).Displayed);
        }
    }
}