using System;
using System.Collections.Generic;
using System.Text;

namespace SwordDamageCalculator
{
    class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        /// <summary>
        /// Contains the calculated damage
        /// </summary>
        public int Damage { get; private set; }

        private int roll;

        /// <summary>
        /// Sets or gets the 3d6 roll
        /// </summary>
        public int Roll { 
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                CalculateDamage();
            } 
        }

        private bool magic;

        /// <summary>
        /// True if the sword is magic, false otherwise
        /// </summary>
        public bool Magic
        {
            get
            {
                return magic;
            }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        private bool flaming;

        /// <summary>
        /// True if the sword is flaming, false otherwise
        /// </summary>
        public bool Flaming
        {
            get
            {
                return flaming;
            }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// Calcualte the damage based on the sword properties
        /// </summary>
        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic)
            {
                magicMultiplier = 1.75M;
            }

            Damage = BASE_DAMAGE;
            Damage += (int)(Roll * magicMultiplier);

            if (flaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }

        /// <summary>
        /// Calculate sword damage based on default values and a starting roll;
        /// </summary>
        /// <param name="startingRoll">Stating 3d6 roll</param>
        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }


    }
}
