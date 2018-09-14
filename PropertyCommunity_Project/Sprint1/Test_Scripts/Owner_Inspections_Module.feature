Feature: Owner Inspections Module
	

@mytag
Scenario:  02 Verify the Inspection Page.
	Given I have logged in successfully using Owner Credentials
	And I have redirected to Dashboard page
	And I have redirected to the Inspection page 
	When I clicked the Detail button	
	Then new page should open about the inspection detail


Scenario: Search for a property under Inspection Page
	Given user have logged into the application
	Then  User search results for property are successfull
