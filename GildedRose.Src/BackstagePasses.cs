namespace GildedRoseKata.Src
{
    public class BackstagePasses:Item
    {
        public BackstagePasses(Item item)
        {
            Name = item.Name;
            Quality = item.Quality;
            SellIn= item.SellIn;
        }

        private const int BackstagePassesSecondCutOff = 6;
        private const int BackstagePassesFirstCutOff = 11;

        internal override void UpdateQuality()
        {
            IncreaseQuality();
            if (WithinFirstCutOff())
            {
                IncreaseQuality();
            }

            if (WithinSecondCutOff())
            {
                IncreaseQuality();
            }
            UpdateExpiration();
            if (HasExpired())
            {
                ResetQuality();
            }
        }

        private  bool WithinFirstCutOff()
        {
            return SellIn < BackstagePassesFirstCutOff;
        }

        private  bool WithinSecondCutOff()
        {
            return SellIn < BackstagePassesSecondCutOff;
        }
    }
}