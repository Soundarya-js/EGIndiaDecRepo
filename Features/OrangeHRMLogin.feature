@Sprint2
Feature: OrangeHRMLogin

A short summary of the feature

Background: 
	Given User is on the orange hrm login page

@sanity
Scenario: Verify login for orange hrm website
	When User enters the "<usrname>" and "<passwd>" in the text fields
	When User clicks on submit button
	Then User is navigated to home page
 
Examples: 
| usrname | passwd   |
| Admin   | admin123 |

@regression
Scenario Outline: Verify login for orange hrm website for invalid credentails
	When  User enters the "<usrname>" and "<passwd>" in the text fields
	When User clicks on submit button
	Then User is on the home page and a error is displayed

Examples: 
| usrname | passwd   |
| Admin   | admin1234 |

@sanity
Scenario Outline: Verify login with test parameters
	When User enters the "<usrname>" and "<passwd>"
	And User clicks on login button
	Then user is navigated to home page
	Then User selects city and country information

	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |

Examples: 
| username | password |
| tom      | harry    |
| jerry    | Mathew   |
