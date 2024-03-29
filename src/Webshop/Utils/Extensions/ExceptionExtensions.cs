﻿using System.Collections.Generic;

namespace Webshop.Utils.Extensions
{
    public static class ExceptionExtensions
    {
        /// <exception cref="KeyNotFoundException">When object is null.</exception>
        public static T ThrowIfNull<T>(this T obj, int id)
        {
            if (obj == null) throw new KeyNotFoundException($"{typeof(T)} with id {id} was not found");

            return obj;
        }

        /// <exception cref="KeyNotFoundException">When object is null.</exception>
        public static T ThrowIfNull<T>(this T obj, string name)
        {
            if (obj == null) throw new KeyNotFoundException($"{typeof(T)} with value {name} was not found");

            return obj;
        }
    }
}