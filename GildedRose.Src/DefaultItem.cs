namespace GildedRoseKata.Src
{
    public class DefaultItem
    {
        public void UpdateQuality(Item item)
        {
            item.DecreaseQuality();
            item.UpdateExpiration();
            if (item.HasExpired())
            {
                item.DecreaseQuality();
            }
        }
    }
}