using System;
using System.Collections.Generic;
using UnityEngine;

namespace Roguelike.Data
{
    public class GameData
    {
        // �� é���� ��ݿ��θ� ������ �迭
        public bool[] isUnlock = new bool[5];

        // �÷��̾ ������ �������� ������ �迭
        public List<int> item = new List<int>();

        // �÷��̾ ������ ��ġ?
        public Transform playerEndTrans;

        // �÷��̾� ����ġ
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