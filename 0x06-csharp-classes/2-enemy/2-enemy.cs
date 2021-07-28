using System;

namespace Enemies
{
    /// <summary>
    /// Defines the Zombie Class.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Zombies health.
        /// </summary>
        public int health;
        
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
    }
}
