using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject.Exceptions
{
    public abstract class ComplexObjectException : Exception
    {
        public ComplexObjectException(string message) : base(message)
        {

        }
    }
}
