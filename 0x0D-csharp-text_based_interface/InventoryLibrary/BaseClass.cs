using System;

namespace InventoryLibrary
{
    /// <summary>
    /// BaseClass Class
    /// </summary>
    public class BaseClass
    {
        private string id;
        private DateTime date_created;
        private DateTime date_updated;

        /// <summary>
        /// Base Class Constuctor
        /// </summary>
        public BaseClass()
        {
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }

        /// <summary>
        /// Get/Set Id
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set 
            { 
                this.id = value;
                this.date_updated = DateTime.Now;
            }
        }

        /// <summary>
        /// Get/Set date_updated
        /// </summary>
        public DateTime Date_updated
        {
            get { return this.date_updated; }
            set { this.date_updated = DateTime.Now; }
        }

        /// <summary>
        /// Get(ONLY) date_created
        /// </summary>
        public DateTime Date_created
        {
            get { return this.date_created; }
        }
    }
}
