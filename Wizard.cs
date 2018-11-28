using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human 
    {
        public Wizard(string name) : base(name)
        {
            // Wizard should have a default health of 50 and intelligence of 25
            this.intelligence = 25;
            this.health = 100;
        }
        public Wizard heal()
        {
            //  Wizard should have a method called heal, which when invoked, heals the Wizard by 10 * intelligence
            this.health += intelligence * 10;
            return this;
        }
        public void fireball(Human target)
        {
            // Wizard should have a method called fireball, which when invoked, decreases the health of whichever object it attacked by some random integer between 20 and 50
            Random rand = new Random();
            int damage = rand.Next(20, 50);

            if(target == null)
            {
                Console.WriteLine("Failed Fireball");
            }
            else
            {
                target.health -= damage;
                Console.WriteLine($"fireball damage: {damage}");
                target.displayInfo();
            }



        }
    }

}