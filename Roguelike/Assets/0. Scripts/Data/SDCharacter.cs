using UnityEngine;
using System;


[CreateAssetMenu(menuName = "Roguelike/CharacterData")] 
public class SDCharacter : ScriptableObject
{
    /// <summary>
    /// 식별번호
    /// </summary>
    public int index;
    public string classname;
    public int accuracy_stat;
    public int speed_stat;
    public int crit_stat;
    public int min_damage_stat;
    public int max_damage_stat;
    public int evasion_stat;
    public int camp;            //0 -> 아군 1 -> 적 2 -> 중립
}