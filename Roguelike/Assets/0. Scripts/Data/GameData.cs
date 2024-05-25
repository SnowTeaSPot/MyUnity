using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable] // 직렬화

public class Data
{
    // 각 챕터의 잠금여부를 저장할 배열
    public bool[] isUnlock = new bool[5];
    
    // 플레이어가 소지한 아이템을 저장할 배열
    public List<int> item = new List<int>();

    // 플레이어 레벨
    public int[] playerLevel;

    // 플레이어 경험치
    public int[] playerEXP;

    // 플레이어가 소유한 캐릭터
    public string[] playerChar;

    // 플레이어가 저장한 위치?
    public Transform playerEndTrans;
}
