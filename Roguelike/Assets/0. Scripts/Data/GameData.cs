using System;
using System.Collections.Generic;
using UnityEngine;

namespace Roguelike.Data
{
    [Serializable]
    public class GameData
    {
        // �� é���� ��ݿ��θ� ������ �迭
        public bool[] isUnlock = new bool[5];

        // �÷��̾ ������ �������� ������ �迭
        public List<int> item = new List<int>();

        // �÷��̾ ������ ��ġ?
        public Transform playerEndTrans;
    }
}