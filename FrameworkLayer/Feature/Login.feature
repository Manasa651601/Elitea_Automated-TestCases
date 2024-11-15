Feature: Login

Scenario Outline: Login with different credentials
Given I navigate to the login page
When I login with username '<username>' and password '<password>'
Then the login '<result>' be successful

Examples:
| username | password | result |
| validuser | validpass | should |
| invaliduser | invalidpass | should not |