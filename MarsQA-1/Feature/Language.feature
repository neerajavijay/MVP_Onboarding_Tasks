Feature: Add languages to Profile

Seller is able to add languages to profile page

@tag1
Scenario Outline: 1 [Add languages to Profile]
	Given [Navigate to Language tab]
	When [I add '<Language>' and '<LanguageLevel>' to Languages tab]
	Then [The Record should be created successfully.]

Examples: 
	| Language | LanguageLevel    |
	| English  | Fluent           |

