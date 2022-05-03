using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class Character
    {
        public string Name;
        public int Health;
        public int Strength;
        public int Defense;

        public Character(string name, int health, int strength, int defense)
        {
            this.Name = name;
            this.Health = health;
            this.Strength = strength;
            this.Defense = defense;
        }

        public bool IsAlive()
        {
            if (this.Health <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int Attack(Character target)
        {
            var rand = new Random();
            int damage = rand.Next((this.Strength/2),this.Strength);
            int tHealth = target.Health;
            if (target.Defense <= this.Strength)
            {
                target.Health -= damage;
            }
            else
            {
                this.Health -= rand.Next((this.Defense/2), (target.Defense));
            }
            return tHealth - target.Health;
        }
    }
}
