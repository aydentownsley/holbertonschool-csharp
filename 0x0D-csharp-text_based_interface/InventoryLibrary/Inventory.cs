using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    /// <summary>
    /// Inventory class
    /// </summary>
    public class Inventory : BaseClass
    {
        private string user_id;
        private string item_id;
        private int quantity;

        /// <summary>
        /// Inventory Constructor
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="item_id"></param>
        /// <param name="quantity"></param>
        public Inventory(string user_id, string item_id, int quantity)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            if (quantity <= 0)
                quantity = 1;
            else
                this.quantity = quantity;
        }

        /// <summary>
        /// Get/Set user id
        /// </summary>
        public string Uid
        {
            get { return this.user_id; }
            set 
            {
                this.user_id = value;
                this.Date_updated = DateTime.Now;
            }
        }

        /// <summary>
        /// Get/Set item id
        /// </summary>
        public string Iid
        {
            get { return this.item_id; }
            set 
            { 
                this.item_id = value;
                this.Date_updated = DateTime.Now;
            }
        }

        /// <summary>
        /// Get/Set Quantity
        /// </summary>
        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value <= 0)
                    quantity = 1;
                else
                    this.quantity = value;
                this.Date_updated = DateTime.Now;
            }
        }
    }
}
