Feature: Inspection Request
	

@mytag
Scenario: Add new inspection request page
	Given I have login successfully using property owner credentials.
	And I have redirected to dashboard page
	And I have opened Inspection page from owner menu
	When I clicked the Add New Inspection Reuest button 
	And I redirected to the Inspection Request page
	And I entered valid input values in all mandatory fields
	And I clicked Save button
	Then the Property Inspection page should open
