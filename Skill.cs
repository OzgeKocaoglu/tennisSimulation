using System;
using System.Collections.Generic;
using System.Text;

namespace tennisSimulation
{
    class Skill
    {
        private string skillName;
        private int skillValue;
        private int id;

        internal string Name { get => skillName; set => skillName = value; }
        internal int Value { get => skillValue; set => skillValue = value; }

        public Skill(string name, int value)
        {
            skillName = name;
            skillValue = value;
            id = ++GlobalVariables.SKILL_COUNT;
        }

    }
}
