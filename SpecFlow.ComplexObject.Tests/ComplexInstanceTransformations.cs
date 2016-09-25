using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SpecFlow.ComplexObject;
using SpecFlow.ComplexObject.Tests.Samples;

namespace SpecFlow.ComplexObject.Tests
{
    [Binding]
    public class DealTransformation
    {
        [StepArgumentTransformation]
        public ClassWithAllSimpleTypes ObjectWithAllSimpleTypesTransformation(Table table)
        {
            return table.CreateComplexInstance<ClassWithAllSimpleTypes>();
        }

        [StepArgumentTransformation]
        public ClassWithPrivateConstructorAndSetter ObjectWithPrivateConstructorAndSetterTransformation(Table table)
        {
            return table.CreateComplexInstance<ClassWithPrivateConstructorAndSetter>();
        }
    }
}
