using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human 
    {
        public Samurai(string name) : base(name)
        {
            // Samurai should have a default health of 200
            this.health = 200;
        }
        public void deathBlow(Human target)
        {
            // Samurai should have a method called death_blow, which when invoked should attack an object and decreases its health to 0 if it has less than 50 health
            if (target.health > 50)
            {
                Console.WriteLine("Failed death blow");
            }
            else
            {
                target.health = 0;
                target.displayInfo();
            }
        }
        // Samurai should have a method called meditate, which when invoked, heals the Samurai back to full health
        public void meditate()
        {
          this.health = 200;
          Console.WriteLine($"{name} used meditate. Restored to full health.");
          displayInfo();
        }
    }
}
