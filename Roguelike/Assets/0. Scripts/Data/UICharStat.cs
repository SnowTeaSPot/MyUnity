using Roguelike.Contents;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Roguelike.Utill
{
    public class UICharStat : MonoBehaviour
    {
        //public Text charIndex;
        public Text charAccuracyData;
        public Text charSpeedData;
        public Text charCritData;
        public Text charDamageData;
        public Text charEvasionData;

        //public void ShowStat(int index)
        //{
        //    //_는 sdCharacters에서 뭐가 들어올지 모르기에 _로 사용하면 들어온 애를 받아서 그 캐릭터의 index가 변수와 같으면 데이터를 가져온다
        //    var sdcharacter = GameManager.SD.sdCharacters.Where(_ => _.index == index).SingleOrDefault();

        //    //Debug.Log($"해당 캐릭터의 SpeedStat = {sdcharacter.speed_stat}");
        //    charAccuracyData.text = $"정확도 : {sdcharacter.accuracy_stat}%";
        //    charSpeedData.text = $"속도 : {sdcharacter.speed_stat}";
        //    charCritData.text = $"치명타 : {sdcharacter.crit_stat}%";
        //    charDamageData.text = $"데미지 : {sdcharacter.min_damage_stat} ~ {sdcharacter.max_damage_stat}";
        //    charEvasionData.text = $"회피 : {sdcharacter.evasion_stat}%";
        //}
        public void ShowStat(int index)
        {
            var charstat = GameObject.Find("GameManager").GetComponent<GameManager>();
            //Debug.Log($"해당 캐릭터의 SpeedStat = {sdcharacter.speed_stat}");
            charAccuracyData.text = $"정확도 : {charstat.myStats[index].modeAccuracyStat}%";
            charSpeedData.text = $"속도 : {charstat.myStats[index].modeSpeedStat}";
            charCritData.text = $"치명타 : {charstat.myStats[index].modeCritStat}%";
            charDamageData.text = $"데미지 : {charstat.myStats[index].modeMinDamageStat} ~ {charstat.myStats[index].modeMaxDamageStat}";
            charEvasionData.text = $"회피 : {charstat.myStats[index].modeEvasionStat}%";
        }

        void Update()
        {
            ShowStat(0);
        }
    }
}