using System;

namespace Enemies
{
    /// <summary>
    /// Defines the Zombie Class.
    /// </summary>
    public class Zombie
    {
        int health;
        string name = "(No name)";
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with value.
        /// <param name="value"> value is health of zombie </param>
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                this.health = value;
        }

        /// <summary>
        /// Gets the health of zombie.
        /// </summary>
        public int GetHealth() { return health; }

        /// <summary>
        /// Gets and sets the name of zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// toString method.
        /// </summary>
        public override string ToString()
        {
            return "Zombie Name: " + this.Name + " / Total Health: " + this.health;
        }
    }
}
