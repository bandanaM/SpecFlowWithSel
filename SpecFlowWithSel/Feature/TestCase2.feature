Feature: TestCase2
@SmokeTest
Scenario: validate Error in Login Page
	Given I enter url on Browser
	Then I enter UserName on username field
	| UserName  |
	| bandana.m |
	Then I enter Password on password field
	| Password  |
	| Ganesh@23 |
    Then I select Domain  from domain dropdown in myHcl login Page
	| Domain  |
	| HCLTECH |
	Then Click Login button
	Then verify Login Error Message