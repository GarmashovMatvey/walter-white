using System;

namespace Scenes
{
    public interface IHealth
    {
        static float maxHealth { get; }
        float curHealth { get; set; }

        public void TakeDamage(int damage)
        {
            
        }

        void Death()
        {

        }

    }
}