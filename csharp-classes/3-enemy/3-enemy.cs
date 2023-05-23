using System;

namespace Enemies
{
    /// <summary>
    /// an empty class Zombie within Enemies namespace
    /// </summary>
    public class Zombie
    {
        /// <summary>
        ///public field health
        /// </summary>
        public int health;
        /// <summary>
        /// public constructor Zombie, health set at 0
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>
        /// public constructor Zombie that checks if value is greater than 0
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
        /// <summary>
        /// public constructor GetHealth that returns health value
        /// </summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
