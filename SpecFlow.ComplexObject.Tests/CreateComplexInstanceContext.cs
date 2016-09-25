using SpecFlow.ComplexObject.Tests.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject.Tests
{
    public class CreateComplexInstanceContext
    {
        public ComplexInstanceSampleClass Expected { get; set; }

        public ComplexInstanceSampleClass MappingResult { get; set; }
    }
}
