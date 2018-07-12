Feature: StudentRepositoryInsert
	Insert Student in Student Repository

@adding
Scenario: Add two numbers
	Given I have an Student without Id
	When I run the method Insert of STudent Repository
	Then the Student Repository should return a Student with Id
