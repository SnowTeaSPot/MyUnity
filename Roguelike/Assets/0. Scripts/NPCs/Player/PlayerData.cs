using System;

namespace Roguelike.Data
{
    [Serializable]
    public class PlayerData
    {
        // 플레이어 경험치
        public string characterName;
        public int playerEXP;
        public int playerLevel;
        public int index;
        public int modeAccuracyStat;
        public int modeSpeedStat;
        public int modeCritStat;
        public int modeMinDamageStat;
        public int modeMaxDamageStat;
        public int modeEvasionStat;
        public int NpcCamp;        
    }
}