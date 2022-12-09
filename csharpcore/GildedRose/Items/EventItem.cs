using System;
using System.Collections;

namespace GildedRose.Items
{
    public class EventItem : Item
    {
        public EventItem(string name, int sellIn, int quality, int price) : base(name, sellIn, quality, price)
        { }

        public override void Update()
        {
            this.UpdateSellIn();
            this.UpdateQuality();
        }

        private void UpdateSellIn()
        {
            this.SellIn--;
        }
        private void UpdateQuality()
        {


            this.Quality++;

            if (this.SellIn <= 10)
                this.Quality++;
            if (this.SellIn <= 5)
                this.Quality++;
            if (this.SellIn <= 0)
                this.Quality = 0;

            FloorQuaityToZero();
            CeilQualityToFifty();
        }

    }
}