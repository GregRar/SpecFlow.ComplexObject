using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject.ValuesInterceptors
{
    //TODO GRAR: test cusomization
    public class NullValueInterceptor : IValueInterceptor
    {
        public string NullTag { get; private set; }

        public NullValueInterceptor()
             : this("<null>")
        {
        }

        public NullValueInterceptor(string emptyStringTag)
        {
            this.NullTag = emptyStringTag;
        }

        public bool Accepts(TargetPropertyTypeInfo propertyTypeInfo, string value)
        {
            return value == this.NullTag && (!propertyTypeInfo.IsValueType || propertyTypeInfo.IsNullable);
        }

        public string GetValue(string originalValue)
        {
            return null;
        }
    }
}
