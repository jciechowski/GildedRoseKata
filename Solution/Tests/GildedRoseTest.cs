using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace GildedRose.Tests
{
    public class GildedRoseTest
    {
        [Fact]
        public void ItemQualityIsNeverNegative()
        {
            var items = new List<Item> {new Item {Name = "foo", SellIn = 0, Quality = 0}};

            var app = new GildedRose(items);
            app.UpdateQuality();
            var item = items[0];

            item.Quality.Should().BeGreaterOrEqualTo(0);
        }

        [Fact]
        public void ItemSellInCanBeNegative()
        {
            var items = new List<Item> {new Item {Name = "foo", SellIn = 0, Quality = 0}};

            var app = new GildedRose(items);
            app.UpdateQuality();
            var item = items[0];

            item.SellIn.Should().BeNegative();
        }
    }
}