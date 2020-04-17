using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonStandard.Extensions
{
    public static class LinqExtensions
    {

        public static bool None<T>(this IEnumerable<T> source) => source == null || !source.Any();

        public static List<List<T>> SplitSequentially<T>(this IEnumerable<T> list, int splitBy)
        {
            List<List<T>> result = new List<List<T>>();
            if (list.None()) return result;

            for (int i = 0; i < list.Count(); i += splitBy)
            {
                var currentList = list.Skip(i).Take(splitBy).ToList();
                result.Add(currentList);
            }
            return result;
        }

        public static IEnumerable<T> Last<T>(this IEnumerable<T> source, int take)
        {
            if (source.None() || take < 0 || source.Count() <= take) return source;
            return source.Skip(source.Count() - take).Take(take);
        }
    }
}
