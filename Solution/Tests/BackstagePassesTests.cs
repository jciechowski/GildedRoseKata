using FluentAssertions;
using Xunit;

namespace GildedRose.Tests
{
    public class BackstagePassesTests
    {
        [Fact]
        public void QualityDropsTo0AfterSellInPassed()
        {
            var backstagePass = new BackstagePasses(0, 15);

            backstagePass.Update();

            backstagePass.Quality.Should().Be(0);
            backstagePass.SellIn.Should().Be(-1);
        }

        [Fact]
        public void QualityDropsTo0FromMaxAfterSellInPassed()
        {
            var backstagePass = new BackstagePasses(0, 50);

            backstagePass.Update();

            backstagePass.Quality.Should().Be(0);
            backstagePass.SellIn.Should().Be(-1);
        }

        [Fact]
        public void QualityIncreaseByOneWhenThereAreMoreThan10DaysToSellIn()
        {
            var backstagePass = new BackstagePasses(11, 0);

            backstagePass.Update();

            backstagePass.Quality.Should().Be(1);
            backstagePass.SellIn.Should().Be(10);
        }

        [Fact]
        public void QualityIncreaseByThreeWhenThereAreBetween5And1DaysToSellIn()
        {
            var backstagePass = new BackstagePasses(4, 0);

            backstagePass.Update();

            backstagePass.Quality.Should().Be(3);
            backstagePass.SellIn.Should().Be(3);
        }

        [Fact]
        public void QualityIncreaseByTwoWhenThereAreBetween10And6DaysToSellIn()
        {
            var backstagePass = new BackstagePasses(10, 25);

            backstagePass.Update();

            backstagePass.Quality.Should().Be(27);
            backstagePass.SellIn.Should().Be(9);
        }
    }
}