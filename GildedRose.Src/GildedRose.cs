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
            var itemToUpdate = ItemToUpdate(item);
            itemToUpdate.UpdateQuality(item);
        }

        private static Item ItemToUpdate(Item item)
        {
            Item itemToUpdate = null;
            if (ItemIsAgedBrie(item))
            {
                itemToUpdate = new AgedBrie();
            }
            if (ItemIsBackstagePasses(item))
            {
                itemToUpdate = new BackstagePasses();
            }
            if (!ItemIsAgedBrie(item) && !ItemIsBackstagePasses(item))
            {
                itemToUpdate = new DefaultItem();
            }
            return itemToUpdate;
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
