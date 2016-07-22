namespace GildedRoseKata.Src
{
    public class ItemFactory
    {
        private const string AgedBrieName = "Aged Brie";
        private const string BackstagePassesName = "Backstage passes to a TAFKAL80ETC concert";

        public static Item ItemWithName(Item item)
        {
            Item itemToUpdate = null;
            if (ItemIsAgedBrie(item.Name))
            {
                itemToUpdate = new AgedBrie();
            }
            if (ItemIsBackstagePasses(item.Name))
            {
                itemToUpdate = new BackstagePasses();
            }
            if (!ItemIsAgedBrie(item.Name) && !ItemIsBackstagePasses(item.Name))
            {
                itemToUpdate = new DefaultItem();
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