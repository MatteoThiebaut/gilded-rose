using System;
using System.Collections.Generic;
using GildedRose.Items;
using System.IO;


namespace GildedRose
{
    public class FileItemsRepository : ItemsRepository
    {
        private List<Item> items = new List<Item>()
        {
            new GenericItem("Wand",9,8,15),
            new GenericItem("Sword",-1,8,20),
            new GenericItem("Shield",-1,1,12),
            new AgingItem("Aged Brie",5,4,5),
            new AgingItem("Aged Brie",5,50,7),
            new LegendaryItem("Sulfuras",5,80,8),
            new EventItem("Backstage Pass",15,10,14),
            new EventItem("Backstage Pass",10,10,13),
            new EventItem("Backstage Pass",5,10,8),
            new EventItem("Backstage Pass",0,10,5),
            new ConjuredItem("Coujured",0,10,9),
        };
        public List<Item> GetInventory()
        {
            return this.items;
        }

        public void SaveInventory(List<Item> items)
        {
            StreamWriter sw = new StreamWriter("Test.txt");

            foreach (Item item in items)
            {
                string itemText = item + ", " + item.Name + ", " + item.Quality + ", " + item.SellIn + ", " + item.Price;
                sw.WriteLine(itemText);
            }

            sw.Close();

        }
    }

}