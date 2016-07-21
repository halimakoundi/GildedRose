using System;
using NUnit.Framework;
using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using GildedRoseKata.Src;
using StatePrinting;

namespace GildedRoseTest
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture()]
    public class GildedRoseTest
    {
        readonly Stateprinter _printer = new Stateprinter();

        [Test]
        public void Verify()
        {
            var items = new List<Item>();
            var gildedRose = new GildedRose(items);

            gildedRose.UpdateQuality();

            Approvals.Verify(_printer.PrintObject(items));
        }

        [Test]
        public void Combinatorial()
        {
            var names = new List<string>
            {
                "Aged Brie",
                "Backstage passes to a TAFKAL80ETC concert",
                "alex",
                "Sulfuras, Hand of Ragnaros"
            };
            var qualities = new List<int> { 10, 0, -1, 50, 51, int.MinValue, Int32.MaxValue };
            var sellins = new List<int> { 11, 6, 0, -1 , int.MinValue, Int32.MaxValue};

            CombinationApprovals.VerifyAllCombinations((name, quality, sellin) =>
            {
                var item = new Item()
                {
                    Name = name,
                    Quality = quality,
                    SellIn = sellin
                };
                var items = new List<Item> { item };
                var gildedRose = new GildedRose(items);

                gildedRose.UpdateQuality();

                return _printer.PrintObject(items);
            }, names, qualities, sellins);
        }

        
    }
}

