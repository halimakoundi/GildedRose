using System;
using System.Collections.Generic;

namespace GildedRoseKata.Src
{
    public class GildedRose
    {
        private const string BackstagePassesName = "Backstage passes to a TAFKAL80ETC concert";
        private const string AgedBrieName = "Aged Brie";
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                UpdateQuality(Items[i]);
            }
        }

        private void UpdateQuality(Item item)
        {
            Item itemToUpdate;
            if (ItemIsAgedBrie(item))
            {
                var agedBrie    = new AgedBrie();
                agedBrie.UpdateQuality(item);
            }
            if (ItemIsBackstagePasses(item))
            {
                itemToUpdate = new BackstagePasses();
                itemToUpdate.UpdateQuality(item);
            }
            if (!ItemIsAgedBrie(item) && !ItemIsBackstagePasses(item))
            {
                itemToUpdate =new DefaultItem();
                itemToUpdate.UpdateQuality(item);
            }
        }

        private static bool ItemIsAgedBrie(Item item)
        {
            return item.Name == AgedBrieName;
        }

        private static bool ItemIsBackstagePasses(Item item)
        {
            return item.Name == BackstagePassesName;
        }
    }
}
