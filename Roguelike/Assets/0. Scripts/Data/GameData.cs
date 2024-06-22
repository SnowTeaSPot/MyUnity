using System;
using System.Collections.Generic;
using UnityEngine;

namespace Roguelike.Data
{
    public class GameData
    {
        // 각 챕터의 잠금여부를 저장할 배열
        public bool[] isUnlock = new bool[5];

        // 플레이어가 소지한 아이템을 저장할 배열
        public List<int> item = new List<int>();

        // 플레이어가 저장한 위치?
        public Transform playerEndTrans;

        // 플레이어 경험치
        public string[] characterName;
        public int[] playerEXP;
        public int[] playerLevel;
        public int[] index;
        public int[] modeAccuracyStat;
        public int[] modeSpeedStat;
        public int[] modeCritStat;
        public int[] modeMinDamageStat;
        public int[] modeMaxDamageStat;
        public int[] modeEvasionStat;
        public string[] camp;
    }
}