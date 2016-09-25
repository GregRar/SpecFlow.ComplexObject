using System;
using FluentAssertions;
using TechTalk.SpecFlow;
using SpecFlow.ComplexObject.Tests.Samples;
using SpecFlow.ComplexObject.Exceptions;

namespace SpecFlow.ComplexObject.Tests
{
    [Binding]
    [Scope(Feature = "CreateObjectWithPrivateConstructorAndSetter")]
    public class CreateObjectWithPrivateConstructorAndSetterSteps
    {
        private readonly CreateComplexInstanceContext<ClassWithPrivateConstructorAndSetter> contex;

        public CreateObjectWithPrivateConstructorAndSetterSteps(CreateComplexInstanceContext<ClassWithPrivateConstructorAndSetter> testContext)
        {
            this.contex = testContext;
        }

        [Given(@"Sample class with private constuctor and private setter and initialized properties")]
        public void GivenSampleComplexClassPrivateConstuctorAndPrivateSetterAndInitializedProperties()
        {
            this.contex.Expected = new ClassWithPrivateConstructorAndSetter("Some property value");
        }

        [When(@"Create instance using data from table and CreateComplexIntance extension")]
        public void WhenCreateInstanceOfTheClassWithPrivateConstuctorAndPrivateSetterUsingDataFromTableAndCreateComplexIntanceExtension(ClassWithPrivateConstructorAndSetter mappingResult)
        {
            this.contex.MappingResult = mappingResult;
        }

        [When(@"Trying to map values on class with no parameterless constuctor")]
        public void WhenTryingToMapValuesOnClassWithNoParameterlessConstuctor(Table table)
        {
            try
            {
                table.CreateComplexInstance<ClassWithNoParameterlessConstructor>();
            }
            catch(Exception ex)
            {
                this.contex.Exceptions.Add(ex);
            }
        }


        [Then(@"the objects should be the same")]
        public void ThenTheObjectsShouldBeTheSame()
        {
            this.contex.MappingResult.ShouldBeEquivalentTo(this.contex.Expected);
        }


        [Then(@"No Parameterless Constructor error should be raised")]
        public void ThenNoParameterlessConstructorErrorShouldBeRaised()
        {
            var exception = this.contex.GetLastException();
            exception.Should().BeOfType<NoParameterlessConstructorException<ClassWithNoParameterlessConstructor>>();
            exception.Message.Should().Be("Type SpecFlow.ComplexObject.Tests.Samples.ClassWithNoParameterlessConstructor has no parameterless constructor. Define at least private parameterless constuctor.");
        }

    }
}
