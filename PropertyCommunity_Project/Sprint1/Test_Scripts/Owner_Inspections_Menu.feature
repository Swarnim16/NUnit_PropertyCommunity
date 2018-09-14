Feature: Owner_Inspections_Menu
	

@mytag
Scenario: 01 Verify Owner and Inspections Menu of Dashboard Page
	Given I have Login successfully as Property Owner
	And I am on the Dashboard page
	When I click on Owner and then Inspection menu
	Then I should have redirected to the Inspections page