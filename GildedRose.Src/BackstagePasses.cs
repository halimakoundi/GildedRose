namespace GildedRoseKata.Src
{
    public class BackstagePasses
    {
        private const int BackstagePassesSecondCutOff = 6;
        private const int BackstagePassesFirstCutOff = 11;

        public static void BackstagePassesItemUpdateQuality(Item item)
        {
            item.IncreaseQuality();
            if (WithinFirstCutOff(item))
            {
                item.IncreaseQuality();
            }

            if (WithinSecondCutOff(item))
            {
                item.IncreaseQuality();
            }
            item.UpdateExpiration();
            if (item.HasExpired())
            {
                item.ResetQuality();
            }
        }

        private static bool WithinFirstCutOff(Item item)
        {
            return item.SellIn < BackstagePassesFirstCutOff;
        }

        private static bool WithinSecondCutOff(Item item)
        {
            return item.SellIn < BackstagePassesSecondCutOff;
        }
    }
}