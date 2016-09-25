using SpecFlow.ComplexObject.Tests.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject.Tests.Sample
{
    public class ComplexInstanceSampleClass
    {
        public string StringEmpty { get; set; }
        public string StringNull { get; set; }
        public string StringValue { get; set; }
        public int IntValue { get; set; }
        public int? IntNullableValue { get; set; }
        public int? IntNullableNull { get; set; }
        public decimal DecimalValue { get; set; }
        public decimal? DecimalNullableValue { get; set; }
        public decimal? DecimalNullableNull { get; set; }
        public double DoubleValue { get; set; }
        public double? DoubleNullableValue { get; set; }
        public double? DoubleNullableNull { get; set; }
        public float FloatValue { get; set; }
        public float? FloatNullableValue { get; set; }
        public float? FloatNullableNull { get; set; }
        public Guid GuidValue { get; set; }
        public Guid? GuidNullableValue { get; set; }
        public Guid? GuidNullableNull { get; set; }
        public YesNoEnum EnumValue { get; set; }
        public YesNoEnum? EnumNullableValue { get; set; }
        public YesNoEnum? EnumNullableNull { get; set; }
    }
}
