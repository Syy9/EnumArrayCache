using System;

namespace Syy.Logics
{
    public static class EnumArrayCache
    {
        private static class EnumArray<T> where T : Enum
        {
            public readonly static T[] Cache = (T[])Enum.GetValues(typeof(T));
        }

        public static T[] Get<T>() where T : Enum
        {
            return EnumArray<T>.Cache;
        }
    }
}
