using System;
using System.Collections.Generic;
using System.Text;

namespace tennisSimulation
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

        public void DisplaySkills()
        {
            for(int i =0; i< skills.Count; i++)
            {
                Console.WriteLine("Skill: " + i + "\nName: " + skills[i].Name);
            }
        }
    }
}
