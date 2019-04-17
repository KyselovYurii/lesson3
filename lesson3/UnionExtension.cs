using System.Collections.Generic;
using System.Linq;

namespace lesson3
{
    static class UnionExtensions
    {
        public static IEnumerable<(string Name, double Latitude, double Longitude)> Union(this IEnumerable<Barcelona> barcelonas,
            IEnumerable<Barcelona> otherBarcelonas)
        {
            return barcelonas.Union(otherBarcelonas, new BarcelonaComparer())
                .Select(x => (x.Name, x.Latitude, x.Longitude));
        }

        public static IEnumerable<(string Name, double Latitude, double Longitude)> UnionAll(this IEnumerable<Barcelona> barcelonas,
            IEnumerable<Barcelona> otherBarcelonas)
        {
            var list = barcelonas.ToList();
            list.AddRange(otherBarcelonas);
            return list.Select(x => (x.Name, x.Latitude, x.Longitude));
        }
    }
}
