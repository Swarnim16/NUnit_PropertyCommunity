Feature: OwnerProperty Menu 
	In Order to check wheather Owner Menu working fine.

@mytag
Scenario:  02 Verify Owner and Property Menu of Dashboard Page
	Given I have Login successfully using Property Owner Credentials
	And I have redirected to the Dashboard page
	When I click on Owner and then Properties menu
	Then I should have redirected to the MyProperties page
