namespace GildedRoseKata.Src
{
    public class ItemFactory
    {
        private const string AgedBrieName = "Aged Brie";
        private const string BackstagePassesName = "Backstage passes to a TAFKAL80ETC concert";

        public static Item New(Item item)
        {
            Item itemToUpdate = null;
            if (ItemIsAgedBrie(item.Name))
            {
                itemToUpdate = new AgedBrie(item);
            }
            if (ItemIsBackstagePasses(item.Name))
            {
                itemToUpdate = new BackstagePasses(item);
            }
            if (!ItemIsAgedBrie(item.Name) && !ItemIsBackstagePasses(item.Name))
            {
                itemToUpdate = new DefaultItem(item);
            }
            return itemToUpdate;
        }

        public static bool ItemIsAgedBrie(string name)
        {
            return name == AgedBrieName;
        }

        public static bool ItemIsBackstagePasses(string name)
        {
            return name == BackstagePassesName;
        }
    }
}