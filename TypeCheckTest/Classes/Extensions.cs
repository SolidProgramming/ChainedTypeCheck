using System.Reflection;

namespace TypeCheckTest.Classes
{
    internal static class Extensions
    {
        internal static (bool, object?) IsChainNull<T>(this T test) where T : IChainable
        {
            object? obj = GetLastImplementingObject<T>(test);

            if (obj == null)
                return (true, default);
            

            return (false, obj);
        }

        public static object? GetLastImplementingObject<T>(object source)
        {
            if (source is null)
                return default;

            PropertyInfo[] propertyInfos = source.GetType().GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Type type = propertyInfo.PropertyType;

                Type? @interface = type.GetInterfaces()
                            .FirstOrDefault(_ => _.Name == typeof(IChainable).Name);

                if (@interface is not null)
                {
                    return GetLastImplementingObject<T>(propertyInfo.GetValue(source));
                }
            }

            return source;
        }
    }
}
