using NUnit.Framework;
using InventoryLibrary;
using System;

namespace Tests
{
    public class Tests
    {
        BaseClass b = new BaseClass();
        Item i = new Item("sword");
        User u = new User("Rick Castle");

        [Test]
        public void BaseTest()
        { Assert.Pass(); }

        /// <summary>
        /// Id's are being set from BaseCalss inheritance
        /// </summary>
        [Test]
        public void IdNotNull()
        {
            Inventory inv = new Inventory(u.Id, i.Id, 2);
            Assert.NotNull(b.Id);
            Assert.NotNull(i.Id);
            Assert.NotNull(u.Id);
            Assert.NotNull(inv.Id);
        }

        /// <summary>
        /// Optional properties are Null or Zero unless set
        /// </summary>
        [Test]
        public void IsNullorZero()
        {
            Assert.Null(i.Description);
            Assert.AreEqual(i.Price, 0);
            Assert.Null(i.Tags);
        }

        /// <summary>
        /// Id can be modified like brief states
        /// </summary>
        [Test]
        public void SetId()
        {
            Inventory inv = new Inventory(u.Id, i.Id, 2);
            string id = Guid.NewGuid().ToString();
            string id2 = Guid.NewGuid().ToString();
            string id3 = Guid.NewGuid().ToString();
            string id4 = Guid.NewGuid().ToString();
            b.Id = id;
            i.Id = id2;
            u.Id = id3;
            inv.Id = id4;
            Assert.AreEqual(id, b.Id);
            Assert.AreEqual(id2, i.Id);
            Assert.AreEqual(id3, u.Id);
            Assert.AreEqual(id4, inv.Id);
        }

        /// <summary>
        /// Names set at instantiation are saved to object
        /// </summary>
        [Test]
        public void CheckName()
        {
            Assert.AreEqual(i.Name, "sword");
            Assert.AreEqual(u.Name, "Rick Castle");
        }
    }
}