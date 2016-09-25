using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using SpecFlow.ComplexObject.Tests.Sample;

namespace SpecFlow.ComplexObject.Tests
{
    [Binding]
    public class CreateComplexInstanceSteps
    {
        private readonly CreateComplexInstanceContext contex;

        public CreateComplexInstanceSteps(CreateComplexInstanceContext testContext)
        {
            this.contex = testContext;
        }

        [Given(@"Sample complex class with initialized properties")]
        public void GivenSampleComplexClassWithInitializedProperties()
        {
            var expected = new ComplexInstanceSampleClass
            {
                StringValue = "String property value",
                StringEmpty = "",
                StringNull = null,
                IntValue = 5,
                IntNullableValue = 10,
                IntNullableNull = null,
                DecimalValue = 2.3m,
                DecimalNullableValue = 5.5m,
                DecimalNullableNull = null,
                DoubleValue = 1.1,
                DoubleNullableValue = 2.2,
                DoubleNullableNull = null,
                FloatValue = 0.6f,
                FloatNullableValue = 0.9f,
                FloatNullableNull = null,
                GuidValue = Guid.Parse("5E302067-4354-49EE-8DAC-E50DA572A3C4"),
                GuidNullableValue = Guid.Parse("39D75B24-5B9B-4FB6-AB82-8CBECBBDF064"),
                GuidNullableNull = null,
                EnumValue = YesNoEnum.Yes,
                EnumNullableValue = YesNoEnum.No,
                EnumNullableNull = null
            };

            this.contex.Expected = expected;
        }
        
        [When(@"Create instance of the same class using data from table and CreateComplexIntance extension")]
        public void WhenCreateInstanceOfTheSameClassUsingDataFromTableAndCreateComplexIntanceExtension(ComplexInstanceSampleClass mappingResult)
        {
            this.contex.MappingResult = mappingResult;
        }
        
        [Then(@"the objects should be the same")]
        public void ThenTheObjectsShouldBeTheSame()
        {
            this.contex.MappingResult.ShouldBeEquivalentTo(this.contex.Expected);
        }
    }
}
