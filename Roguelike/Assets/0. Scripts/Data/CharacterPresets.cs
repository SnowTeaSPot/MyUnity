using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPresets : ScriptableObject
{
    public class Knight
    {
        //스테이터스//
        public int accuracy_stat = 100;
        public int speed_stat = 10;
        public int crit_stat = 15;
        public int min_damage_stat = 6;
        public int max_damage_stat = 10;
        public int evasion_stat = 5;
    }

    public class Thief
    {
        //스테이터스//
        public int accuracy_stat = 100;
        public int speed_stat = 16;
        public int crit_stat = 25;
        public int min_damage_stat = 5;
        public int max_damage_stat = 12;
        public int evasion_stat = 15;
    }

    public class Archemist
    {
        //스테이터스//
        public int accuracy_stat = 50;
        public int speed_stat = 13;
        public int crit_stat = 10;
        public int min_damage_stat = 4;
        public int max_damage_stat = 7;
        public int evasion_stat = 7;
    }

    public class Priest
    {
        //스테이터스//
        public int accuracy_stat = 80;
        public int speed_stat = 7;
        public int crit_stat = 10;
        public int min_damage_stat = 2;
        public int max_damage_stat = 5;
        public int evasion_stat = 7;
    }
}
