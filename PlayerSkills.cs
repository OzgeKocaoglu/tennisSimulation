using System;
using System.Collections.Generic;
using System.Text;

namespace tennisSimulation
{
    class PlayerSkills
    {
        List<Skill> skills;
        public PlayerSkills()
        {
            skills = new List<Skill>();
        }

        public void AddSkill(string skillName, int skillValue)
        {
            Skill newSkill = new Skill(skillName, skillValue);
            skills.Add(newSkill);
        }
    }
}
