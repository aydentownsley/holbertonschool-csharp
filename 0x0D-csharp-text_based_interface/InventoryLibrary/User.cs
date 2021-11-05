using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    /// <summary>
    /// User Class
    /// </summary>
    public class User : BaseClass
    {
        private string name;

        /// <summary>
        /// User Concstructor
        /// </summary>
        /// <param name="name"></param>
        public User(string name)
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
    }
}
