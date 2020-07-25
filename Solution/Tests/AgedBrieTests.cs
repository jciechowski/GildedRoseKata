using FluentAssertions;
using Xunit;

namespace GildedRose.Tests
{
    public class AgedBrieTests
    {
        [Fact]
        public void QualityIncresesWithTime()
        {
            var brie = new AgedBrie(10, 10);

            brie.Update();

            brie.SellIn.Should().Be(9);
            brie.Quality.Should().Be(11);
        }

        [Fact]
        public void QualityCanBeGreaterThanMax()
        {
            var brie = new AgedBrie(1, 50);

            brie.Update();

            brie.SellIn.Should().Be(0);
            brie.Quality.Should().Be(50);
        }
    }
}