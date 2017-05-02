using System;
using System.Collections;
using System.Collections.Generic;

namespace IMQ1.Reflection.List.Library
{
    public static class ListBuilder
    {
        public static IList Build(Type type)
        {
            var listType = typeof(List<>);
            var constructedListType = listType.MakeGenericType(type);
            var instance = Activator.CreateInstance(constructedListType);
            return (IList)instance;
        }
    }
}
