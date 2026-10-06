namespace overridingthehorse
{
    public class HealSkill : Skill
    {
       private float bonusHeal;
        public HealSkill()
        {
            bonusHeal = 20f;
            Console.WriteLine("---Konstruktor Default Heal Skill---");
        }

        public HealSkill(float bonusHeal, string name, float power, float cost) : base (name, power, cost)
        {
            Console.WriteLine("---Konstruktor Parameter---");
            this.bonusHeal = bonusHeal;
        }
        public override float CalculateDmg()
        {
            Console.WriteLine("[HealSkill.CalculateDmg] Mennghitung damage magic dengan crit...");
            float healAmount = basePower + bonusHeal;
            return healAmount;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Bonus Hea;    :" + (bonusHeal));
            Console.WriteLine("==========================");
        } 
    }
}