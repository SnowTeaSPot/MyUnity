using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable] // ����ȭ

public class Data
{
    // �� é���� ��ݿ��θ� ������ �迭
    public bool[] isUnlock = new bool[5];
    
    // �÷��̾ ������ �������� ������ �迭
    public List<int> item = new List<int>();

    // �÷��̾� ����
    public int[] playerLevel;

    // �÷��̾� ����ġ
    public int[] playerEXP;

    // �÷��̾ ������ ĳ����
    public string[] playerChar;

    // �÷��̾ ������ ��ġ?
    public Transform playerEndTrans;
}
