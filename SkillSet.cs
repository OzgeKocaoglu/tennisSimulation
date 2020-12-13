using System.Collections.Generic;

namespace Tennis_Simulation
{
    class SkillSet
    {
        private List<Skill> skills;

        public SkillSet()
        {
            skills = new List<Skill>();
        }

        public void CreateSkill(string name, int value)
        {
            Skill newSkill = new Skill(name, value);
            skills.Add(newSkill);
        }

        public List<Skill> GetSkills()
        {
            return skills;

        }


    }
}
