namespace GildedRoseKata.Src
{
    public class DefaultItem : Item
    {
        public DefaultItem(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn = item.SellIn;
        }

        internal override void UpdateQuality()
        {
            DecreaseQuality();
            UpdateExpiration();
            if (HasExpired())
            {
                DecreaseQuality();
            }
        }
    }
}