Feature: Validate Error in Login Page

Scenario: validate Error in Login Page
	Given I enter url in Browser
	Then I enter UserName in username field
	| UserName  |
	| bandana.m |
	Then I enter Password in password field
	| Password  |
	| Ganesh@23 |
     Then I select Domain from domain dropdown
	| Domain  |
	| HCLTECH |
	Then Click submit button
	Then verify Login Error Message