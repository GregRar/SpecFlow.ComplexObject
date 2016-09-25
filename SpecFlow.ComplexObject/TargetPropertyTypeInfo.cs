using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.ComplexObject
{
    public class TargetPropertyTypeInfo
    {
        public Type PropertyType { get; private set; }

        public bool IsValueType { get; private set; }

        public bool IsNullable { get; private set; }

        public Type NullableType { get; set; }

        public static TargetPropertyTypeInfo ConvertFromPropertyInfo(PropertyInfo propertyInfo)
        {
            var propertyType = propertyInfo.PropertyType;

            if (!propertyType.IsValueType)
            {
                return CreateForNonValueType(propertyType);
            }

            if (propertyInfo.PropertyType.IsGenericType && propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                var nullableType = Nullable.GetUnderlyingType(propertyType);
                return CreateForNullableValueType(propertyType, nullableType);
            }

            return CreateForNonNullableValueType(propertyType);
        }

        private static TargetPropertyTypeInfo CreateForNonValueType(Type propertyType)
        {
            return new TargetPropertyTypeInfo
            {
                PropertyType = propertyType,
                IsValueType = false,
                IsNullable = false,
                NullableType = null
            };
        }

        private static TargetPropertyTypeInfo CreateForNonNullableValueType(Type propertyType)
        {
            return new TargetPropertyTypeInfo
            {
                PropertyType = propertyType,
                IsValueType = true,
                IsNullable = false,
                NullableType = null
            };
        }

        private static TargetPropertyTypeInfo CreateForNullableValueType(Type propertyType, Type nullableType)
        {
            return new TargetPropertyTypeInfo
            {
                PropertyType = propertyType,
                IsValueType = true,
                IsNullable = true,
                NullableType = nullableType
            };
        }
    }
}
