using System;

namespace overridingthehorse
{
    public class Skill
    {
        protected string ?skillName;
        protected float basePower;
        protected float Cost;

        //KOnstruktor default
        public Skill()
        {
            skillName = "Basic Skill";
            basePower = 10f;
            Cost = 5f;
            Console.WriteLine("---Skill Default---");
        }
        //Konstruktor berparameter
        public Skill(string name, float power, float cost)
        {
            Console.WriteLine("---Kontruktor parameter---");
            skillName = name;
            basePower = power;
            Cost = cost;
        }
        public virtual float CalculateDmg()
        {
            Console.WriteLine("[Skill.CalculateDmg] menghitung damage dasar");
            return basePower;
        }
        public float CalculateDmg(float multiplier)
        {
            Console.WriteLine($"[Skill.CalculateDamage] mengihitung damage dengan multiplier: {multiplier}");
            return basePower * multiplier;
        }
        public float CalculateDmg(float multiplier, float targetDefense)
        {
            Console.WriteLine($"[Skill.CalculateDamage] Menghitung damage dengan multiplier: {multiplier} dan defence {targetDefense}");
            float damage = basePower * multiplier;
            damage -= targetDefense * 0.5f;
            if (damage <= 0) damage = 0;
            return damage;
        }
        public float CalculateDmg(string damageType)
        {
            Console.WriteLine($"[Skill.CalculateDamage] menghitung damage tipe: {damageType}");
            float damage = basePower;
            if (damageType == "Piercing")
            damage *= 1.3f;
            if (damageType == "Blunt")
            damage *= 1.3f;
            return damage;
        }
        public void Display()
        {
            Console.WriteLine("Skill name   :" + skillName);
            Console.WriteLine("Base Power   :" + basePower);
            Console.WriteLine("Cost         :" + Cost);
        }
    }
}   