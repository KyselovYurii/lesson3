using System.Collections.Generic;

namespace lesson3
{
    class BarcelonaComparer : IEqualityComparer<Barcelona>
    {
        public bool Equals(Barcelona barcelona1, Barcelona barcelona2)
        {
            if (ReferenceEquals(barcelona1, barcelona2))
            {
                return true;
            }

            if (ReferenceEquals(barcelona1, null) || ReferenceEquals(barcelona2, null))
            {
                return false;
            }

            return barcelona1.Id == barcelona2.Id && barcelona1.Name == barcelona2.Name &&
                barcelona1.ZipCode == barcelona2.ZipCode && barcelona1.Location == barcelona2.Location &&
                barcelona1.Country == barcelona2.Country && barcelona1.Latitude == barcelona2.Latitude &&
                barcelona1.Longitude == barcelona2.Longitude;
        }
        
        public int GetHashCode(Barcelona barcelona)
        {
            if (ReferenceEquals(barcelona, null))
            {
                return 0;
            }

            int hash = 17;
            hash = hash * 23 + barcelona.Id.GetHashCode();
            hash = hash * 23 + (barcelona.Name ?? string.Empty).GetHashCode();
            hash = hash * 23 + (barcelona.ZipCode ?? string.Empty).GetHashCode();
            hash = hash * 23 + (barcelona.Location ?? string.Empty).GetHashCode();
            hash = hash * 23 + (barcelona.Country ?? string.Empty).GetHashCode();
            hash = hash * 23 + barcelona.Latitude.GetHashCode();
            hash = hash * 23 + barcelona.Longitude.GetHashCode();

            return hash;
        }
    }
}
