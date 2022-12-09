using System;
using System.Collections;

namespace GildedRose.Items
{
    public class LegendaryItem : Item
    {
        public LegendaryItem( string name, int sellIn, int quality, int price) : base(name, sellIn, quality, price) {}

        public override void Update(){}
       
    }
}