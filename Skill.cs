﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Simulation
{
    class Skill
    {
        #region Variables
        private string skillName;
        private int skillValue;
        private int id;
        #endregion
        #region Getter/Setter
        internal string Name { get => skillName; set => skillName = value; }
        internal int Value { get => skillValue; set => skillValue = value; }
        #endregion

        public Skill(string name, int value)
        {
            skillName = name;
            skillValue = value;
            id = ++GlobalVariables.SKILL_COUNT;
        }

    }
}
