using System;
using System.Collections;

namespace GildedRose.Items
{
    public abstract class Item
    {
        public string Name { get; protected set; }
        public int SellIn { get; protected set; }
        public int Quality { get; protected set; }
        public int Price { get; protected set; }


        public Item(string name, int sellIn, int quality, int price){
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
            this.Price = price;
        }
        

        public abstract void Update();

        protected void FloorQuaityToZero()
        {
            if(this.Quality < 0)
                this.Quality = 0;
        }
        protected void CeilQualityToFifty()
        {
            if(this.Quality > 50)
                this.Quality = 50;
        }

       
    }
}