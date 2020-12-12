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
            InitiliazeSkills();
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
            Console.WriteLine("------------------------------------");
            for (int i =0; i< skills.Count; i++)
            {
                Console.WriteLine("Skill: " + i + "\nName: " + skills[i].Name + "\nValue: " + skills[i].Value);
            }
        }

        //TO DO: Json dosyasından çek.
        public void InitiliazeSkills()
        {
            CreateSkill("Grass", 0);
            CreateSkill("Hard", 0);
        }

    }
}
