Feature: Add Education to Profile

Seller is able to add Education to profile page

@tag1
Scenario Outline: [Add Education to Profile]
	Given I am on my Profile page
	When [I add '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' to Education tab]
	Then [The Education Record with '<Degree>' should be created successfully]

Examples: 
	| Country | University   | Title  | Degree                   | Year |
	| India   | KSR       | M.Tech | Information Technology   | 2014 |
    