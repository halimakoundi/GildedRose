using System;
using System.Collections.Generic;

namespace GildedRoseKata.Src
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                UpdateQuality(i);
            }
        }

        private void UpdateQuality(int index)
        {
            var itemToUpdate = ItemFactory.New(Items[index]);
            itemToUpdate.UpdateQuality();
            UpdateItem(index, itemToUpdate);
        }

        private void UpdateItem(int index, Item itemToUpdate)
        {
            Items[index] = new Item()
            {
                Quality = itemToUpdate.Quality,
                Name = itemToUpdate.Name,
                SellIn = itemToUpdate.SellIn
            };
        }
    }
}
