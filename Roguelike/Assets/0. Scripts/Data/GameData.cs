using System;
using System.Collections.Generic;
using UnityEngine;

namespace Roguelike.Data
{
    [Serializable]
    public class GameData
    {
        // 각 챕터의 잠금여부를 저장할 배열
        public bool[] isUnlock = new bool[5];

        // 플레이어가 소지한 아이템을 저장할 배열
        public List<int> item = new List<int>();

        // 플레이어가 저장한 위치?
        public Transform playerEndTrans;
    }
}