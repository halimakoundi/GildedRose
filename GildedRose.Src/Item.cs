using System;

namespace GildedRoseKata.Src
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        internal void DecreaseQuality()
        {
            if (Quality > 0 && IsMutable())
            {
                Quality -= 1;
            }
        }

        private bool IsMutable()
        {
            return Name != "Sulfuras, Hand of Ragnaros";
        }

        internal void IncreaseQuality()
        {
            if (Quality < 50)
            {
                Quality += 1;
            }
        }

        internal void ResetQuality()
        {
            Quality = 0;

        }

        internal virtual void UpdateQuality()
        {
            throw new NotImplementedException();
        }

        internal void UpdateExpiration()
        {
            if (IsMutable())
            {
                SellIn -= 1;
            }
        }

        internal bool HasExpired()
        {
            return SellIn < 0;
        }

        public virtual void UpdateQuality(Item item)
        {
            
        }
        
    }
}