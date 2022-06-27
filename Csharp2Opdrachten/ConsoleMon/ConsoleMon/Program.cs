using System;

namespace ConsoleMon
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMonArena factory = new ConsoleMonArena();

            ConsoleMon a = new ConsoleMon();
            ConsoleMon b = new ConsoleMon();

            Skill fireball = new Skill();
            Skill thunderbolt = new Skill();

            a.skills.Add(fireball);
            b.skills.Add(thunderbolt);





            factory.DoBattle(a, b);
        }
    }
}
