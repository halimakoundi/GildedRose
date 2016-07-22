namespace GildedRoseKata.Src
{
    public class AgedBrie:Item
    {
        

        public void UpdateQuality(Item item)
        {
            item.IncreaseQuality();
            item.UpdateExpiration();
            if (item.HasExpired())
            {
                item.IncreaseQuality();
            }
        }
    }
}