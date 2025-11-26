using System;
using System.Collections.Generic;
using System.Text;

namespace whatever
{
    internal class GameCharacter
    {
        public GameCharacter(int health, int strength, int stamina)
        {
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }

        public int Health;
        public int Strength;
        public int Stamina;
        public static void Fight(GameCharacter character)
        {

            
        }

        public static void ReCharge()
        {
            
        }
    }
}
