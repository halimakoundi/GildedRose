namespace GildedRoseKata.Src
{
    public class DefaultItem:Item
    {
        public override void UpdateQuality(Item item)
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