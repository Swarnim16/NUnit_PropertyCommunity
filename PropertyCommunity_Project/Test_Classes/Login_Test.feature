Feature: Login Page Test
	In order to verify Login Page

@mytag
Scenario Outline: 01 Login functionality with Valid credentials of Owner
	Given I have opened the Login page
	And I have entered valid <userName>, valid <password>
	When I click on Login button
	Then the Dashboard page should open 
	And I should able to do Logout

	Examples: 
	| userName                       | password |
	| vincent.nguyen@mvpstudio.co.nz | ntmv2682 | 

