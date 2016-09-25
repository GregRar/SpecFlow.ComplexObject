using SpecFlow.ComplexObject.ValuesInterceptors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow.ComplexObject
{
    public static class ComplexInstanceExtensions
    {
        public static ComplexInstanceExtensionSettings Settings { get; private set; }

        static ComplexInstanceExtensions()
        {
            Settings = new ComplexInstanceExtensionSettings(
                new EmptyStringValueInterceptor(),
                new NullValueInterceptor());
        }

        //TODO GRAR: Similar function for objects that doesn't have parameterless constructor and you pass instance
        public static TTarget CreateComplexInstance<TTarget>(this Table table)
            where TTarget : new()
        {

            var target = new TTarget();

            //TODO GRAR: Check table structure (if has 2 rows!)
            var properties = table.Rows.Select(row => new PropertyData(row[0], row[1]));

            foreach (var propertyData in properties)
            {
                SetPropertyValue(target, propertyData);
            }

            return target;
        }

        //TODO GRAR exception handling with explicit info and whole value path
        public static void SetPropertyValue<TTarget>(TTarget target, PropertyData propertyData)
        {
            var targetType = typeof(TTarget);

            //TODO GRAR: what if doesn't exists?
            var property = targetType.GetProperty(propertyData.Name);
            var targetTypeInfo = TargetPropertyTypeInfo.ConvertFromPropertyInfo(property);

            //TODO GRAR: what if more then 1?
            var valueInterceptor = Settings.ValueInterceptors.SingleOrDefault(interceptor => interceptor.Accepts(targetTypeInfo, propertyData.Value));

            var value = valueInterceptor != null ? valueInterceptor.GetValue(propertyData.Value) : propertyData.Value;

            var convertedValue = ConvertValueToTargetType(value, targetTypeInfo);

            //TODO GRAR: what if types doesn't match and what if has private setter?
            property.SetValue(target, convertedValue, null);
        }

        private static object ConvertValueToTargetType(string value, TargetPropertyTypeInfo targetTypeInfo)
        {
            //TODO GRAR: InvalidCastException
            //TODO GRAR: FormatException for example when string is ""
            if(targetTypeInfo.IsValueType)
            {
                if(targetTypeInfo.IsNullable)
                {
                    if(value == null)
                    {
                        return null;
                    }
                    else
                    {
                        return Convert(value, targetTypeInfo.NullableType);
                    }
                }
                else
                {
                    if (value == null)
                    {
                        //TODO GRAR: exception handling with full path
                        throw new InvalidCastException("Can't convert null into non nullable type");
                    }
                    else
                    {
                        return Convert(value, targetTypeInfo.PropertyType);
                    }
                }
            }

            return Convert(value, targetTypeInfo.PropertyType);
        }

        private static object Convert(string value, Type targetType)
        {
            if(value == null)
            {
                return null;
            }

            return TypeDescriptor.GetConverter(targetType).ConvertFromInvariantString(value);
        }
    }
}
