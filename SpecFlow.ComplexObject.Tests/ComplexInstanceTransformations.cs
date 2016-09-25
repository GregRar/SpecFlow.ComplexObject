using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SpecFlow.ComplexObject;
using SpecFlow.ComplexObject.Tests.Sample;

namespace SpecFlow.ComplexObject.Tests
{
    [Binding]
    public class DealTransformation
    {
        [StepArgumentTransformation]
        public ComplexInstanceSampleClass ComplexInstanceSampleClassTransformation(Table table)
        {
            return table.CreateComplexInstance<ComplexInstanceSampleClass>();
        }
    }
}
