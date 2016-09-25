Feature: CreateObjectWithPrivateConstructorAndSetter
	In order to keep proper domain objects encapsulation
	As a test enigneer
	I want extenstion to create & map to target object even if it has private parameterless constructor and private property setters


Scenario: Map data on target object with private constuctor and private setter
	Given Sample class with private constuctor and private setter and initialized properties
	When Create instance using data from table and CreateComplexIntance extension 
	| property                  | value               |
	| PropertyWithPrivateSetter | Some property value |
Then the objects should be the same

Scenario: Raise descriptive error when no parameterless constructor found
	When Trying to map values on class with no parameterless constuctor
	| property | value               |
	| Param    | Some property value |
	Then No Parameterless Constructor error should be raised
 