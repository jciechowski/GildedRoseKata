using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                switch (item)
                {
                    case BackstagePasses backstagePass:
                        backstagePass.Update();
                        continue;
                    case AgedBrie agedBrie:
                        agedBrie.Update();
                        continue;
                    case Sulfuras sulfuras:
                        sulfuras.Update();
                        continue;
                    default:
                        if (item.IsConjured())
                        {
                            UpdateConjuredItem(item);
                        }
                        else
                        {
                            UpdateNormalItem(item);
                        }

                        break;
                }
            }
        }

        private static void UpdateNormalItem(Item item)
        {
            item.SellIn--;

            item.DecreaseQuality();

            if (item.SellIn < 0)
            {
                item.DecreaseQuality();
            }
        }

        private void UpdateConjuredItem(Item item)
        {
            if (item.SellIn >= 0)
            {
                item.DecreaseQuality();
                item.DecreaseQuality();
                item.SellIn--;

                return;
            }

            item.DecreaseQuality();
            item.DecreaseQuality();
            item.DecreaseQuality();
            item.DecreaseQuality();
            item.SellIn--;
        }
    }
}