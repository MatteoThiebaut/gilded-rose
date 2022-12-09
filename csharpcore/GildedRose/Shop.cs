using System;
using System.Collections.Generic;
using GildedRose.Items;



namespace GildedRose
{
    public class Shop
    {
        private ItemsRepository repository;

        public Shop(ItemsRepository repository)
        {
            this.repository = repository;
        }
     
        public void updateInventory()
        {
            List<Item> items = this.repository.GetInventory();
            foreach (Item item in items)
                item.Update();
            this.repository.SaveInventory(items);
        }

    }
}