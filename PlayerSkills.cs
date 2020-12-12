using System;
using System.Collections.Generic;
using System.Text;

namespace tennisSimulation
{
    class PlayerSkills
    {
        private SkillSet skills;
        internal SkillSet SkillSet { get => skills; set => skills = value; }

        public PlayerSkills()
        {
            skills = new SkillSet();
        }

        public void SetPlayerSkillValue(Skill skill, int value)
        {

        }

    }
}
