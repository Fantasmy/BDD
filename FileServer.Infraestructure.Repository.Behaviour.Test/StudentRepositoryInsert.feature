Feature: StudentRepositoryInsert
	Insert Student in Student Repository

@adding
Scenario: Add two numbers
	Given I have a Student without Id
	When I run the method Insert of Student Repository
	Then The Student Repository should return a Student with Id
