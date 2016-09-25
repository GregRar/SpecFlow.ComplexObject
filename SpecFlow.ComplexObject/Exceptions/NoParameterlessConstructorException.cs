using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject.Exceptions
{
    public class NoParameterlessConstructorException<TType> : ComplexObjectException
    {
        public NoParameterlessConstructorException()
            : base(string.Format("Type {0} has no parameterless constructor. Define at least private parameterless constuctor.", typeof(TType)))
        {

        }
    }
}
