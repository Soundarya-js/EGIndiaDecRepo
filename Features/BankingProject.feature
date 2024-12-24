Feature: Banking Application Login

A short summary of the feature

@customer
Scenario: Customer login
    Given user is on the login page
    When User clicks the customer login
    And User selects the "<username>" from the dropdown
    And User clicks the login button
    Then User is logged in and can see data
   
Examples: 
| username     |
| Harry Potter |

@manager
Scenario: Bank Manager Login
	Given Manager is on login page
	When Customer clicks on Bank Manager Login button
	And Clicks on Add Customer Button
	And enters firstname, lastname, postalcode
	| firstname | lastname | postalcode |
	| Soundarya  | Suresh  | 573165     |
	And clicks on Add new Customer Button
	Then new Customer is added
	| firstname | lastname | postalcode |
	| Soundarya  | Suresh  | 573165     |
	
