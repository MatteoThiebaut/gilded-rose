using System.Collections.Generic;
using GildedRose;
using GildedRose.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests
{
    [TestClass]
    public class ShopTests
    {
        private Shop shop;
        private ItemsRepository repository;


        [TestInitialize]
        public void _setup()
        {
            this.repository = new InMemoryItemsRepository();
            this.shop = new Shop(repository);
            this.shop.updateInventory();
        }
        [TestMethod]
        public void Should_UpdateItemProperties()
        {
            Assert.AreEqual(8, this.repository.GetInventory()[0].SellIn);
            Assert.AreEqual(7, this.repository.GetInventory()[0].Quality);

        }
        [TestMethod]
        public void Should_DecreaseQualityTwiceAsFastAfterExpiration()
        {
            Assert.AreEqual(6, this.repository.GetInventory()[1].Quality);

        }
        [TestMethod]
        public void Should_NotHaveNegativeQuality()
        {
            Assert.AreEqual(0, this.repository.GetInventory()[2].Quality);

        }
        [TestMethod]
        public void Should_IncreaseAgedBrieQuality()
        {
            Assert.AreEqual(5, this.repository.GetInventory()[3].Quality);

        }
        [TestMethod]
        public void Should_IncreaseQualityPassFifty()
        {
            Assert.AreEqual(50, this.repository.GetInventory()[4].Quality);

        }
        [TestMethod]
        public void Should_NotUpdateLengendaryItemProperties()
        {
            Assert.AreEqual(5, this.repository.GetInventory()[5].SellIn);
            Assert.AreEqual(80, this.repository.GetInventory()[5].Quality);

        }
        [TestMethod]
        public void Should_IncreaseBackstagePassQuality()
        {
            Assert.AreEqual(11, this.repository.GetInventory()[6].Quality);

        }
        [TestMethod]
        public void Should_IncreaseBackstagePassQualityByTwoTenDaysBefore()
        {
            Assert.AreEqual(12, this.repository.GetInventory()[7].Quality);
        }
        [TestMethod]
        public void Should_IncreaseBackstagePassQualityByThreeFiveDaysBefore()
        {
            Assert.AreEqual(13, this.repository.GetInventory()[8].Quality);
        }
        [TestMethod]
        public void Should_SetBackstagePassQualityToZeroAfterEvent()
        {
            Assert.AreEqual(0, this.repository.GetInventory()[9].Quality);
        }
        [TestMethod]
        public void Should_IncreaseQualityForConjuredItem()
        {
            Assert.AreEqual(7, this.repository.GetInventory()[10].Quality);
        }
        [TestMethod]
        public void Should_ItemGetPrice()
        {
            Assert.AreEqual(9, this.repository.GetInventory()[10].Price);
        }
     


    }
}