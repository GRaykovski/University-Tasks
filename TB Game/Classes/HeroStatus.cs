using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Game
{
    class HeroStatus
    {

        private static IList<BaseHero> BaseHeroes = new List<BaseHero>()
            {
              new Berserker()
                {
                    Name = "Bam",
                    Health = 1500,
                    Defense = 12,
                    Attack = 70,
                    Agility = 30
                },
              new Berserker()
                {
                    Name = "Vegeta",
                    Health = 1500,
                    Defense = 12,
                    Attack = 70,
                    Agility = 30
                },
             new Druid()
            {
                Name = "King",
                Health = 1200,
                Defense = 35,
                Attack = 60,
                Agility = 40
            },
             new Druid()
            {
                Name = "Dumbledor",
                Health = 1200,
                Defense = 35,
                Attack = 60,
                Agility = 40
            },

              new Mage()
            {
                Name = "Merlin",
                Health = 1000,
                Defense = 25,
                Attack = 50,
                Agility = 25
            },
              new Mage()
            {
                Name = "Ryze",
                Health = 1000,
                Defense = 25,
                Attack = 50,
                Agility = 25
            },
             new Warrior()
            {
                Name = "Meliodas",
                Health = 1000,
                Defense = 45,
                Attack = 67,
                Agility = 35
            },
             new Warrior()
            {
                Name = "Arthur",
                Health = 800,
                Defense = 45,
                Attack = 47,
                Agility = 45
            }
        };
        
           private List<Warrior> filteredWarriors = BaseHeroes.OfType<Warrior>().ToList();
        private Random random = new Random();
        public BaseHero getRandomWarrior()
        {
            return filteredWarriors.ElementAt(random.Next(filteredWarriors.Count()));
        }

        private List<Mage> filteredMages = BaseHeroes.OfType<Mage>().ToList();
        public BaseHero getRandomMage()
        {
            return filteredMages.ElementAt(random.Next(filteredWarriors.Count()));
        }

        private List<Druid> filteredDruids = BaseHeroes.OfType<Druid>().ToList();
        public BaseHero getRandomDruid()
        {
            return filteredDruids.ElementAt(random.Next(filteredWarriors.Count()));
        }

        private List<Berserker> filteredBerserkers = BaseHeroes.OfType<Berserker>().ToList();
        public BaseHero getRandomBerserker()
        {
            return filteredBerserkers.ElementAt(random.Next(filteredWarriors.Count()));
        }
    
    }
}

