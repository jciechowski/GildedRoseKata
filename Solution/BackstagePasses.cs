namespace GildedRose
{
    public class BackstagePasses : Item
    {
        public BackstagePasses(int sellIn, int quality)
        {
            Name = "Backstage passes to a TAFKAL80ETC concert";
            SellIn = sellIn;
            Quality = quality;
        }

        public void Update()
        {
            if (!this.QualityIsNotMaxed())
            {
                if (SellIn <= 0)
                {
                    Quality = 0;
                }

                SellIn--;

                return;
            }

            if (SellIn > 10)
            {
                this.IncreaseQuality();
            }

            if (SellIn <= 10 && SellIn >= 6)
            {
                this.IncreaseQuality();
                this.IncreaseQuality();
            }

            if (SellIn <= 5 && SellIn > 0)
            {
                this.IncreaseQuality();
                this.IncreaseQuality();
                this.IncreaseQuality();
            }

            if (SellIn <= 0)
            {
                Quality = 0;
            }

            SellIn--;
        }
    }
}