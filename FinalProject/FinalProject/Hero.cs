using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Hero
    {
        private string Alterego;
        private string Weakness;
        private bool Antihero;
        private string Gender;
        private string Race;

        public string Power;
        public int PowerLevel;
        public double Health;
        public string Weapons;
        public int Age;
        public string Name;
        public string nemesis;

        public Hero()
        {
        }

        public Hero(string name, string nemesis, string race, string power)
        {
            this.Name = name;
            this.nemesis = nemesis;
            this.Race = race;
            this.Power = power;
        }

        public Hero(string name, string nemesis, string race, string power, bool antihero)
        {
            this.Name = name;
            this.nemesis = nemesis;
            this.Race = race;
            this.Power = power;
            this.Antihero = antihero;
        }
        public Hero(string name, string nemesis, string power)
        {
            this.Name = name;
            this.nemesis = nemesis;
            this.Race = "Human";
            this.Power = power;
            this.Antihero = false;
        }

        // TODO: Problem 1 - add a constructor method with a different number and/or types of parameters

        public void FightCrime(string address)
        { if (this.PowerLevel > 49)
            {
                Console.WriteLine("Successfully fought crime at {0}",address);
            }
        else
            {
                Console.WriteLine("Failed to fight crime at {0}", address);
            }
                
                

            // TODO: Problem 2 - Output "Successfully fought crime at address" if PowerLevel > 49
        }

        public bool Investigate()
        {
            // TODO: Problem 3 - output "Investigated Crime" and return true
            bool returnValue = true;
            Console.WriteLine("Investigated Crime");
            return returnValue;
        }

        public void Fly()
        {
            // TODO: Problem 4 - if Power contains Fly, then output "Name is Flying!" else output "Name can't fly!"
            if (this.Power.Contains("Fly"))
            {
                Console.WriteLine("{0} is flying!", this.Name);
            }
            else
            {
                Console.WriteLine("{0} can't fly! ", this.Name);
            }
        }

        public void Craft(string material, int numMaterials)
        {
            Console.WriteLine("Crafting with " + material);
        }

        public void Climb(int height)
        {
            Console.WriteLine(this.Name + " is climbing");
        }
       
        public int ChargePower()
        {
            // TODO: Problem 5 - increase this.PowerLevel by 1
            this.PowerLevel++;
            return this.PowerLevel;
        }

        // TODO: Problem 6 - Add an overloaded method ChargePower that has a parameter for increaseAmount.  Add increaseAmount to this.PowerLevel and return the new value for this.PowerLevel (try to use a loop calling the other ChargePower)
        public int ChargePower(int increaseAmount)
        {for (int i = 0; i < increaseAmount; i++)
                ChargePower();
            return this.PowerLevel;
        }
    }
}
