Feature: CalculatorM
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProjectAs1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Sub two numbers
	Given the first number is 10
	And the second number is 20
	When the two numbers are Subtracted
	Then the result should be 10

Scenario: Mul two numbers
	Given the first number is 10
	And the second number is 20
	When the two numbers are Multiplication
	Then the result should be 200

Scenario: Div two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are Division
	Then the result should be 2