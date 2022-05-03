using System;
using System.Collections.Generic;


namespace Learn
{
    internal static class Program
    {
        static void Main()
        {
            Character character = new Character("Jagle", 100, 10, 7);
            Character target = new Character("Nooskya", 150, 7, 10);
            int round = 1;
            int cDmg = 0;
            int tDmg = 0;
            while (character.IsAlive() == true && target.IsAlive() == true)
            {
                round += 1;
                Console.WriteLine("Round " + round);
                cDmg = character.Attack(target);
                tDmg = target.Attack(character);

                Console.WriteLine("{0} attack {1} for {2} damage, only {3} hp left\n", character.Name, target.Name, tDmg, character.Health);
                Console.WriteLine("{0} attack {1} for {2} damage, only {3} hp left\n", target.Name, character.Name, cDmg, target.Health);
                
            }
            if(character.IsAlive() == true){

            Console.WriteLine("{0} is dead {1} killed him and still have {2} hp\n", target.Name, character.Name, character.Health);
                
            } else if(character.IsAlive() == false && target.IsAlive() == false)
            {
                Console.WriteLine("Both {0} and {1} are dead, there is no winner", character.Name, target.Name);
            }
            else
            {
                Console.WriteLine("{0} is dead {1} killed him and still have {2} hp\n", character.Name, target.Name, target.Health);
            }
        }
    }
}
