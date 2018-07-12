Feature: Validate Login Page

Scenario: validate Login Page
	Given I enter url in Browser
	Then I enter UserName in username field
	| UserName  |
	| bandana.m |
	Then I enter Password in password field
	| Password  |
	| Ganesh@04 |
    Then I select Domain from domain dropdown
	| Domain  |
	| HCLTECH |
	Then Click submit button
	Then verify Welcome Page