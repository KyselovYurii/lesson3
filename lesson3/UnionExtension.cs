using System.Collections.Generic;

namespace lesson3
{
    static class UnionExtensions
    {
        public static IEnumerable<(string Name, double Latitude, double Longitude)> Union(this IEnumerable<Barcelona> barcelonas,
            IEnumerable<Barcelona> otherBarcelonas)
        {
            var dict = new Dictionary<int, Barcelona>();
            foreach (var barcelona in barcelonas)
            {
                dict.Add(barcelona.Id, barcelona);
                yield return (barcelona.Name, barcelona.Latitude, barcelona.Longitude);
            }

            foreach (var otherBarcelona in otherBarcelonas)
            {
                if (!dict.ContainsKey(otherBarcelona.Id))
                {
                    dict.Add(otherBarcelona.Id, otherBarcelona);
                    yield return (otherBarcelona.Name, otherBarcelona.Latitude, otherBarcelona.Longitude);
                }
            }
        }

        public static IEnumerable<(string Name, double Latitude, double Longitude)> UnionAll(this IEnumerable<Barcelona> barcelonas,
            IEnumerable<Barcelona> otherBarcelonas)
        {
            foreach (var x in barcelonas)
            {
                yield return (x.Name, x.Latitude, x.Longitude);
            }

            foreach (var x in otherBarcelonas)
            {
                yield return (x.Name, x.Latitude, x.Longitude);
            }
        }
    }
}
