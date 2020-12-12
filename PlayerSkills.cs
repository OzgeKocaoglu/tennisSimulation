using System;
using System.Collections.Generic;
using System.Text;

namespace tennisSimulation
{
    class PlayerSkills
    {
        public SkillSet skills;
        public PlayerSkills()
        {
            skills = new SkillSet();
            IniliazeSkills();
        }

        public void IniliazeSkills()
        {
           /* for(int i =0; i< skills.GetSkills().Count; i++)
            {
                skills.GetSkills()[i].Value = 1;
            }*/
            
        }

    }
}
