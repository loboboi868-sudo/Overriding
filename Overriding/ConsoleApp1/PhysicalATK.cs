namespace overridingthehorse
{
    public class Physicalskill : Skill
    {
        private float critRate;
        public Physicalskill()
        {
            critRate = 0.1f;
            Console.WriteLine("---Konstruktor Default Physical Skill---");
        }

        public Physicalskill(float critRate, string name, float power, float cost) : base (name, power, cost)
        {
            Console.WriteLine("---Konstruktor Parameter---");
            this.critRate = critRate;
        }
        public override float CalculateDmg()
        {
            Console.WriteLine("[PhysicalSkill.CalculateDmg] Mennghitung damage physical dengan crit...");
            float damage = basePower * (1 + critRate);
            return damage;
        }
        public float CalculateDmg(bool isBackstab)
        {
            Console.WriteLine($"[PhysicalSkill.CalculateDamage] menghitung damage fisik dengan bcakstab: {isBackstab}");
            float damage = basePower * (1+ critRate);
            if(isBackstab)
            damage *= 1.5f;
            return damage;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Crit Rate    :" + (critRate * 100f) + "%");
            Console.WriteLine("==========================");
        }
    }
}