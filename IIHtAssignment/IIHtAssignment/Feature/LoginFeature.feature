Feature: LogInFeature
	Check if login functinality works

@login
Scenario: LogIn User as Administrator
	Given I Navigate to application
	And I click on the login link
	And I enter username and password
	    | userName    | passWord  |
	    | a@gmail.com | India1234 |
	And I click on siginin button
	Then Verify that error message displayed on screen