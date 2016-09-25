using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject.Tests.Samples
{
    public class ClassWithPrivateConstructorAndSetter
    {
        private ClassWithPrivateConstructorAndSetter()
        {

        }

        public ClassWithPrivateConstructorAndSetter(string propertyValue)
        {
            this.PropertyWithPrivateSetter = propertyValue;
        }

        public string PropertyWithPrivateSetter { get; private set; }
    }
}
