Feature: Add,Edit and Delete Skills from Profile page

Seller is able to add,update and delete skills from profile page


@tag1
Scenario Outline: 1 [Add skills to Profile]
	Given [Navigate to Skills tab]
	When [I add '<Skill>' and '<SkillLevel>' to Skills tab]
	Then [The Skill Record should be created successfully]

Examples: 
	| Skill          | SkillLevel   |
	| C#             | Beginner     |
   
	
