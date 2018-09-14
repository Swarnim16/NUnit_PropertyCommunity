Feature: List A Rental Page
	In Property Page a Button Available
	


@mytag
Scenario: 03 Verify List A Rental function with valid values.
	Given I have logged in successfully using Property Owner Credentials
	And I have redirected to the Dashboard page
	And I have redirected to the Property page 
	When I clicked the List A Rental button
	And I entered valid values into List Rental Property page
	And I clicked the Save button
	Then successfull save message should deisplay
