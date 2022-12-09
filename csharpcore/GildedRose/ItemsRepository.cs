using System;
using System.Collections.Generic;
using GildedRose.Items;



namespace GildedRose
{
    public interface ItemsRepository
    {
        List<Item> GetInventory();
        void SaveInventory(List<Item> items);
    }

}