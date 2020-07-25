namespace GildedRose
{
    public class AgedBrie : Item
    {
        public AgedBrie(int sellIn, int quality)
        {
            Name = "Aged Brie";
            SellIn = sellIn;
            Quality = quality;
        }

        public void Update()
        {
            SellIn--;
            if (!this.QualityIsNotMaxed())
            {
                return;
            }

            if (SellIn < 0)
            {
                this.IncreaseQuality();
                this.IncreaseQuality();

                return;
            }

            this.IncreaseQuality();
        }
    }
}