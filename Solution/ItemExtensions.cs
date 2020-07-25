using System;

namespace GildedRose
{
    public static class ItemExtensions
    {
        public static void DecreaseQuality(this Item item)
        {
            if (QualityIsPositive())
            {
                item.Quality--;
            }

            bool QualityIsPositive()
            {
                return item.Quality > 0;
            }
        }

        public static void IncreaseQuality(this Item item)
        {
            if (item.QualityIsNotMaxed())
            {
                item.Quality++;
            }
        }

        public static bool QualityIsNotMaxed(this Item item) => item.Quality < 50;

        public static bool IsConjured(this Item item) =>
            item.Name.Contains("conjured", StringComparison.InvariantCultureIgnoreCase);
    }
}