using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class ConsoleMon
    {
        internal int health = 100;
        internal int energy = 100;
        internal string name = "Milad met een T";

        internal List<Skill> skills = new List<Skill>();

        internal enum weakness
        {

        }

        internal ConsoleMon()
        {
            
        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.health = copyFrom.health;
            this.energy = copyFrom.energy;
            this.name = copyFrom.name;
        }

        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energyaf)
        {
            energy -= energyaf;
        }

    }
    class Skill
    {
        internal int damage = 50;
        internal int energyCost = 10;
        internal string name = "Milad met een T";

        internal List<Skill> skills = new List<Skill>();
        internal enum element
        {

        }

        public void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            target.TakeDamage(damage);
            caster.DepleteEnergy(energyCost);

        }
        internal Skill()
        {

        }

        internal Skill(Skill copyFrom)
        {
            damage = copyFrom.damage;

            for (int i = 0; i < copyFrom.skills.Count; i++)
            {
                Skill copyFromThisSkill = copyFrom.skills[i];
                Skill copy = new Skill(copyFromThisSkill);

                this.skills.Add(copy);
            }
        }
    }
    internal class ConsoleMonArena
    {
        public void DoBattle(ConsoleMon a, ConsoleMon b)
        {
            Random random = new Random();

            Skill skillA = a.skills[random.Next(2)];
            Skill skillB = b.skills[random.Next(2)];

            while (a.health > 0 || b.health > 0)
            {
                skillA.UseOn(b, a);
                skillB.UseOn(a, b);

                Console.WriteLine(a.health);
                Console.WriteLine(b.health);


            }

        }
    }

}
