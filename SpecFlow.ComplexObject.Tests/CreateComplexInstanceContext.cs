using SpecFlow.ComplexObject.Tests.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject.Tests
{
    public class CreateComplexInstanceContext<TTarget>
    {
        public CreateComplexInstanceContext()
        {
            this.Exceptions = new List<Exception>();
        }

        public TTarget Expected { get; set; }

        public TTarget MappingResult { get; set; }

        public List<Exception> Exceptions { get; private set; }

        public Exception GetLastException()
        {
            return this.Exceptions.Last();
        }
    }
}
