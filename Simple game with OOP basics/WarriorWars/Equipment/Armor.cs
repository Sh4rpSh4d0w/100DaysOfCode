﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Armor
    {
        private int GOOD_GUY_ARMOR = 5;
        private int BAD_GUY_ARMOR = 5;

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR;

                    break;
                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;

                    break;
                default:
                    break;
            }
        }
    }
}