using System;
using System.Collections;

namespace GildedRose.Items
{
    public class GenericItem : Item
    {
        public GenericItem(string name, int sellIn, int quality, int price) : base(name, sellIn, quality, price)
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
            if (this.SellIn < 0)
                this.Quality--;

            this.Quality--;

            FloorQuaityToZero();
            CeilQualityToFifty();
        }

    }
}