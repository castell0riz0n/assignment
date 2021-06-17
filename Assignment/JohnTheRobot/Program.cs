using System;
using System.Collections.Generic;
using System.Linq;

namespace JohnTheRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill());
            
            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());
            
            Console.ReadLine();
        }
    }

    public class Humanoid
    {
        private BaseClass skill;

        public Humanoid(BaseClass type)
        {
            this.skill = type;
        }

        public Humanoid()
        {
            this.skill = new BaseClass();
        }

        public string ShowSkill()
        {
            return string.IsNullOrEmpty(skill.SkillName) ? "no skill is defined" : skill.SkillName;
        }
    }

    public class BaseClass
    {
        public string SkillName { get; set; } = "";
    }

    public class Dancing : BaseClass
    {
        public Dancing()
        {
            this.SkillName = "Dancing";
        }
    }

    public class Cooking : BaseClass
    {
        public Cooking()
        {
            this.SkillName = "Cooking";
        }
    }
}