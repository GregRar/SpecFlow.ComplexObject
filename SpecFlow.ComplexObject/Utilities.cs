using SpecFlow.ComplexObject.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject
{
    internal class Utilities
    {
        public static TTarget CreateInstance<TTarget>()
            where TTarget: class
        {
            Type t = typeof(TTarget);

            var constructorInfo = t.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null);

            if (constructorInfo == null)
            {
                throw new NoParameterlessConstructorException<TTarget>();
            }

            return (TTarget)constructorInfo.Invoke(new object[0]);
        }
    }
}
