using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Game
{
    class Berserker:BaseHero
    {
        public Berserker(string name = "", int maxH = 0 , int defense = 0, int attack = 0 , int agility = 0)
            :base(name, maxH,defense, attack, agility)
        {
        }

        public override string Status()
        {
            string status = ($"{Name} has {maxH} health\r\n {defense} defense\r\n {attack} attack power \r\n {agility} speed\r\n" +
                $" This hero also has the Special Skill 'Rage'.\r\n");
            Console.WriteLine(status);
            return status;
        }

    }
}
