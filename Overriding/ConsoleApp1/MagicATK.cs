namespace overridingthehorse
{
        public class Magisskill : Skill
    {
        private string ?element;
        public Magisskill()
        {
            element = "normal";
            Console.WriteLine("---Konstruktor Default Magid Skill---");
        }

        public Magisskill(string element, string name, float power, float cost) : base (name, power, cost)
        {
            Console.WriteLine("---Konstruktor Parameter---");
            this.element = element;
        }
        public override float CalculateDmg()
        {
            Console.WriteLine("[MagicSkill.CalculateDmg] Mennghitung damage magic dengan crit...");
            float damage = basePower;

            if (element == "Fire")
            {
                damage *= 1.5f;
                Console.WriteLine("[MagicSkill.CalculateDmg] Menghitung Damage Magic Tipe Fire...");
            }
            else if (element == "ice")
            {
                damage *= 1.2f;
                Console.WriteLine("[MagicSkill.CalculateDmg] Menghitung Damage Magic Tipe Ice...");
            }
            return damage;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Element    :" + (element));
            Console.WriteLine("==========================");
        }
        
    }
}