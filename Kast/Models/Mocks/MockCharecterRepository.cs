using System.Collections.Generic;
using Kast.Models.DnD5E;

namespace Kast.Models.Mocks
{
    public class MockCharecterRepository : ICharecterRepository
    {
        private IEnumerable<Stat> CreateStats(int str, int dex, int con, int inte, int wis, int cha)
        {
            return new List<Stat>()
                {
                    new Stat(EnumStats.Str, str),
                    new Stat(EnumStats.Dex, dex),
                    new Stat(EnumStats.Con, con),
                    new Stat(EnumStats.Int, inte),
                    new Stat(EnumStats.Wis, wis),
                    new Stat(EnumStats.Cha, cha)
                };
        }

        private DndClass CreateDefualdClaric(int level, IEnumerable<string> skillProf)
        {
            return new DndClass() { Name = "Claric", Level = level, SkillProf = skillProf};
        }

        private DndClass CreateDefualdWizzard(int level, IEnumerable<string> skillProf)
        {
            return new DndClass() { Name = "Wizzard", Level = level, SkillProf = skillProf };
        }
        
        public IEnumerable<Character> Charecters
        {
            get
            {
                var classes = new List<DndClass>()
                {
                    CreateDefualdClaric(1, new List<string> { "Arcana", "Arcana", "History", "History" }),
                    CreateDefualdWizzard(4, new List<string>())
                };

                var stats = CreateStats(8, 14, 14, 16, 14, 10);

                var race = new Race()
                {
                    //SavingThrowProf = new List<EnumStats>()
                    //{
                     //   EnumStats.Cha,
                     //   EnumStats.Int
                    //},
                    SkillProf = new List<string> { "Insight", "Investifation", "Perception"},
                    Name = "Elf"
                };

                var backgrund = new Background
                {
                    Name = "Sage",
                    SkillProf = new List<string> { "Religion", "Nature" }
                };

                return new List<Character>()
                {
                    new Character("Ajaton", "Kasper Steenstrup", race, backgrund,  classes, stats){ CharacterId = 0},
                    new Character("Akezera", "Kasper Steenstrup", race, backgrund, classes, stats){ CharacterId = 1}
                };
            }
        }

        public Topic GetTopicCharecterId(int charecterId)
        {
            throw new System.NotImplementedException();
        }
    }
}
