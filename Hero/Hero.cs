﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Game_2
{
    public class Hero
    {
        public string name;
        public string clasS;
        public double health;
        public double maxhealth;
        public double mana;
        public double maxmana;
        public double manaregen;
        public double action;
        public double maxaction;
        public double actionregen;
        public double armour;
        public double maxarmour;
        public double evasion;
        public double maxevasion;
        public double damage;
        public double truedamage;
        public double critical;
        public double maxcritical;
        public double initiative;
        public int level;
        public double experience;
        public int maxexperience;

        public static int money = 5;

        public static double maxhealthstatic = 0;
        public static double manaregenstatic = 0;
        public static double actionregenstatic = 0;
        public static double evasionstatic = 0;
        public static double damagestatic = 0;
        public static double criticalstatic = 0;
        public Hero(string aName, string aClass, double aHealth, double aMaxhealth, double aMana, double aMaxmana, double aManaregen,
            double aAction, double aMaxaction, double aActionregen, double aArmour, double aMaxarmour, double aEvasion, double aMaxevasion,
            double aDamage, double aTruedamage, double aCritical, double aMaxcritical, double aInitiative, int aLevel, double aExperience, int aMaxexperience)
        {
            name = aName;
            clasS = aClass;
            health = aHealth;
            maxhealth = aMaxhealth;
            mana = aMana;
            maxmana = aMaxmana;
            manaregen = aManaregen;
            action = aAction;
            maxaction = aMaxaction;
            actionregen = aActionregen;
            armour = aArmour;
            maxarmour = aMaxarmour;
            evasion = aEvasion;
            maxevasion = aMaxevasion;
            damage = aDamage;
            truedamage = aTruedamage;
            critical = aCritical;
            maxcritical = aMaxcritical;
            initiative = aInitiative;
            level = aLevel;
            experience = aExperience;
            maxexperience = aMaxexperience;
        }

        public void AbilitiesPerClass(string clasS, double mana, double action)
        {
            Console.WriteLine("");
            switch (clasS)
            {
                case "Knight":
                    KnightAbilities(mana, action);
                    break;

                case "Hunter":
                    HunterAbilities(mana, action);
                    break;

                case "Rogue":
                    RogueAbilities(mana, action);
                    break;
            }
        }

        private static void RogueAbilities(double mana, double action)
        {
            if (action < 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[1] Phantom slash     [attack|evade next attack[10 action]");
            Console.ForegroundColor = ConsoleColor.White;

            if (action < 6)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[2] Stab weak spot    [deal true damage|double critical chance[6 action]");
            Console.ForegroundColor = ConsoleColor.White;

            if (mana < 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[3] Magic smoke bomb  [evade next attack[4 mana]");
            Console.ForegroundColor = ConsoleColor.White;

            if (mana < 10 || action < 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[4] Magical stim pack [heal 10 health|evasion +5% for this battle[10 mana|5 action]");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void HunterAbilities(double mana, double action)
        {
            if (mana < 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[1] Magical Arrow     [deal 150% damage[5 mana]");
            Console.ForegroundColor = ConsoleColor.White;

            if (action < 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[2] Piercing Shot     [deal true damage[5 action]");
            Console.ForegroundColor = ConsoleColor.White;

            if (mana < 15)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[3] Hellfire          [deal 300% damage[15 mana]");
            Console.ForegroundColor = ConsoleColor.White;

            if (action < 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[4] Recuperation      [heal 8 health|evade next attack[10 action]");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void KnightAbilities(double mana, double action)
        {
            if (mana < 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[1] Magic Slash       [deal 200% damage[5 mana]");
            Console.ForegroundColor = ConsoleColor.White;

            if (action < 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[2] Heavy Slash       [deal 200% damage[5 action]");
            Console.ForegroundColor = ConsoleColor.White;

            if (mana < 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[3] Magical Shield    [200% shield[1 turn][2 mana]");
            Console.ForegroundColor = ConsoleColor.White;

            if (action < 6)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            Console.WriteLine("[[4] Emergency Heal    [heal 5 health[6 action]");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
