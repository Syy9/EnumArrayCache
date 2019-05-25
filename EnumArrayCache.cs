using System;
using System.Collections;
using System.Collections.Generic;

namespace Syy.Logics
{
    public static class EnumArrayCache<T> where T : Enum
    {
        static Dictionary<Type, T[]> _caches = new Dictionary<Type, T[]>();

        public static T[] Get()
        {
            var type = typeof(T);
            T[] result = null;
            if (_caches.TryGetValue(type, out result))
            {
                return result;
            }

            return _caches[type] = (T[])Enum.GetValues(type);
        }

        public static void Clear()
        {
            _caches.Clear();
        }
    }
}
