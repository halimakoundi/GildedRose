namespace GildedRoseKata.Src
{
    public class DefaultItem
    {
        public static void DefaultItemUpdateQuality(Item item)
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