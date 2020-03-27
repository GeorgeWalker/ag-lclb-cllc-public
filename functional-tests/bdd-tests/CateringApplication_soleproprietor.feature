﻿Feature: CateringApplication_soleproprietor
    As a logged in business user
    I want to submit a Catering Application for a sole proprietor

Scenario: Start Application
    Given I am logged in to the dashboard as a sole proprietorship
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