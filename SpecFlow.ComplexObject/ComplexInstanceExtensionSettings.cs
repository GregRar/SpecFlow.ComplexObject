using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject
{
    public class ComplexInstanceExtensionSettings
    {
        public List<IValueInterceptor> ValueInterceptors { get; private set; }

        public ComplexInstanceExtensionSettings()
        {
            this.ValueInterceptors = new List<IValueInterceptor>();
        }

        public ComplexInstanceExtensionSettings(params IValueInterceptor[] valueInterceptors)
        {
            if (valueInterceptors != null)
            {
                this.ValueInterceptors = valueInterceptors.ToList();
            }
        }
    }
}
