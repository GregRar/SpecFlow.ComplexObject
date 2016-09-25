using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject
{
    public interface IValueInterceptor
    {
        bool Accepts(TargetPropertyTypeInfo propertyTypeInfo, string value);

        string GetValue(string originalValue);
    }
}
