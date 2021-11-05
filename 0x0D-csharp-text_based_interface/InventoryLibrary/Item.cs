using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    /// <summary>
    /// Item Class
    /// </summary>
    public class Item : BaseClass
    {
        private string name;
        private string description;
        private float price;
        private List<string> tags;

        /// <summary>
        /// Item Constructor
        /// </summary>
        /// <param name="name"></param>
        public Item(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Get/Set Name
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set 
            { 
                this.name = value;
                this.Date_updated = DateTime.Now;
            }
        }

        /// <summary>
        /// Get/Set Description
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set 
            { 
                this.description = value;
                this.Date_updated = DateTime.Now;
            }
        }

        /// <summary>
        /// Get/Set Price
        /// </summary>
        public float Price
        {
            get { return this.price; }
            set 
            { 
                this.price = value;
                this.Date_updated = DateTime.Now;
            }
        }

        /// <summary>
        /// Get/Set Tags
        /// </summary>
        public List<string> Tags
        {
            get { return this.tags; }
            set 
            { 
                this.tags = value;
                this.Date_updated = DateTime.Now;
            }
        }
    }
}
