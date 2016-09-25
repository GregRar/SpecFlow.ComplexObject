Feature: CreateComplexInstance
	In order to avoid code duplication for mapping between table and  complex objects 
	As a test enigneer
	I want extenstion to map values from the table into object

@mytag
Scenario: Map data from table using CreateComplexIntance extension
	Given Sample complex class with initialized properties
	When Create instance of the same class using data from table and CreateComplexIntance extension 
	| property             | value                                |
	| StringValue          | String property value                |
	| StringEmpty          | <empty>                              |
	| StringNull           | <null>                               |
	| IntValue             | 5                                    |
	| IntNullableValue     | 10                                   |
	| IntNullableNull      | <null>                               |
	| DecimalValue         | 2.3                                  |
	| DecimalNullableValue | 5.5                                  |
	| DecimalNullableNull  | <null>                               |
	| DoubleValue          | 1.1                                  |
	| DoubleNullableValue  | 2.2                                  |
	| DoubleNullableNull   | <null>                               |
	| FloatValue           | 0.6                                  |
	| FloatNullableValue   | 0.9                                  |
	| FloatNullableNull    | <null>                               |
	| GuidValue            | 5E302067-4354-49EE-8DAC-E50DA572A3C4 |
	| GuidNullableValue    | 39D75B24-5B9B-4FB6-AB82-8CBECBBDF064 |
	| GuidNullableNull     | <null>                               |
	| EnumValue            | Yes                                  |
	| EnumNullableValue    | No                                   |
	| EnumNullableNull     | <null>                               |
	#TODO
	#| CustomStructure      |                       |
	#| Dic["Key"]                 |                       |
	#| Collection[0]              |                       |
	#| Collection[1]              |                       |
	#| Collection[0].Name         |                       |
	#| Collection[0].City         |                       |
	#| Collection[0].Name[0]      |                       |
	#| Collection[0].City[1]      |                       |
	#| Collection[0].Name[0].Name |                       |
	#| Collection[0].City[1].City |                       |
	#| ComplexProperty.Name       |                       |
	#| ComplexProperty.Name.Title |                       |
	Then the objects should be the same 
