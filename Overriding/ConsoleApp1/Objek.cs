namespace overridingthehorse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Demo Override & Overload===");
            //membuat physical skill
            Physicalskill slash = new Physicalskill(0.3f, "slash", 50f, 15f);
            slash.Display();
            //calculateDamage
            Console.WriteLine("\n--- Menguji overloading method ---");
            //1.override base class tanpa parameter
            float dmg1 = slash.CalculateDmg();
            Console.WriteLine("Damage (tanpa parameter):" + dmg1);
            //2.dengan 1 parameter
            float dmg2 = slash.CalculateDmg(4.0f);
            Console.WriteLine("Damage (parameter 1):" + dmg2);
            //3.dengan 2 parameter
            float dmg3 = slash.CalculateDmg(4.0f, 30f);
            Console.WriteLine("Damage (parameter 1):" + dmg3);
            //4. dengan 1 parameter (string)
            float dmg4 = slash.CalculateDmg("Piercing");
            Console.WriteLine("Damage (parameter 1):" + dmg4);
            //5. dengan 1 parameter (bool isBackstab)- overload si subclass
            float dmg5 = slash.CalculateDmg(true);
            Console.WriteLine("Damage (parameter 1):" + dmg5);
            Console.ReadKey();
        }
    }
}