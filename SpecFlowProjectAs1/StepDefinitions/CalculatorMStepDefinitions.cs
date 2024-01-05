using System;
using TechTalk.SpecFlow;
using Class;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowProjectAs1.StepDefinitions
{
    [Binding]


    public class ASDCalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Class1 calculator;
        private int result;
        public ASDCalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new Class1();
        }   

            [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
                calculator.Fnum = p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
                calculator.Snum = p0;
            }

        [When(@"the two numbers are Subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
                result = calculator.Sub();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
                calculator.Fnum = p0;

            }

            [When(@"the two numbers are Multiplication")]
        public void WhenTheTwoNumbersAreMultiplication()
        {
                result = calculator.mul();

        }

            [When(@"the two numbers are Division")]
        public void WhenTheTwoNumbersAreDivision()
        {
                result = calculator.div();
        }
    }
}
