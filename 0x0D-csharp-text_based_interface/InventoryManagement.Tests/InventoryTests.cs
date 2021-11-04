using NUnit.Framework;
using InventoryLibrary;
using System;

namespace Tests
{
    public class Tests
    {
        BaseClass b1 = new BaseClass();
        Item i1 = new Item("sword");

        [Test]
        public void IdNotNull()
        {
            Assert.NotNull(b1.Id);
            Assert.NotNull(i1.Name);
        }

        [Test]
        public void SetId()
        {
            string id = Guid.NewGuid().ToString();
            b1.Id = id;
            Assert.AreEqual(id, b1.Id);
            Assert.AreEqual(i1.Name, "sword");
        }
    }
}