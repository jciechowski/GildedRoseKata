using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedBrie(2, 0),
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Sulfuras(0),
                new Sulfuras(-1),
                new BackstagePasses(15, 20),
                new BackstagePasses(10, 49),
                new BackstagePasses(5, 49),
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            var app = new GildedRose(items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");

                foreach (var t in items)
                {
                    Console.WriteLine(t.Name + ", " + t.SellIn + ", " + t.Quality);
                }

                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}