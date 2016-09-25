using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject.Tests.Samples
{
    public class ClassWithNoParameterlessConstructor
    {
        public ClassWithNoParameterlessConstructor(string param)
        {

        }

        public string Param { get; set; }
    }
}
