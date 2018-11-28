using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human 
    {
        public Ninja(string name) : base(name)
        {
            //Ninja should have a default dexterity of 175
            this.dexterity = 175;
        }
        public void steal(Human target)
        {
            if (target == null)
            {
                Console.WriteLine("Failed Steal");
            }
            else
            {
                // Ninja should have a steal method, which when invoked, attacks an object and increases the Ninjas health by 10
                this.health += 10;
                target.health -= 10;
                displayInfo();
            }
        }
        public void getAway()
        {
          this.health -= 15;
          Console.WriteLine($"{name} got used GetAway.");
          displayInfo();
        }
    }
}

