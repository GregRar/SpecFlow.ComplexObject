using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject.ValuesInterceptors
{
    public class EmptyStringValueInterceptor : IValueInterceptor
    {
        //TODO GRAR: test cusomization
        public string  EmptyStringTag { get; private set; }

        public EmptyStringValueInterceptor()
             : this("<empty>")
        {
        }

        public EmptyStringValueInterceptor(string emptyStringTag)
        {
            this.EmptyStringTag = emptyStringTag;
        }

        public bool Accepts(TargetPropertyTypeInfo propertyTypeInfo, string value)
        {
            return value == this.EmptyStringTag && propertyTypeInfo.PropertyType == typeof(string);
        }

        public string GetValue(string originalValue)
        {
            return string.Empty;
        }
    }
}
