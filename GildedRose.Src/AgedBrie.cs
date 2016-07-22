namespace GildedRoseKata.Src
{
    public class AgedBrie:Item
    {
        public AgedBrie(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn = item.SellIn;
        }

        internal override void UpdateQuality()
        {
            IncreaseQuality();
            UpdateExpiration();
            if (HasExpired())
            {
                IncreaseQuality();
            }
        }
    }
}