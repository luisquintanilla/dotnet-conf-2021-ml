using System;
using System.Reflection;

namespace Manufaktura.Core.Reflection
{
    public static class ReflectionExtensions
    {
        public static object GetDefaultValue(this Type type)
        {
            if (type.GetTypeInfo().IsValueType)
            {
                return Activator.CreateInstance(type);
            }
            return null;
        }
    }
}