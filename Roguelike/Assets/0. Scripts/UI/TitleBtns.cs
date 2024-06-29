using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.U2D.Path;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Roguelike.Data
{

    public class TitleBtns : MonoBehaviour
    {
        public int mode = 1;


        public void NewBtn()
        {
            CreatePlayer(1000);
            CreatePlayer(1001);
            if (GameObject.Find("GameManager").GetComponent<GameManager>().playerCount == 2)
                SceneManager.LoadScene("Stage01");
        }

        public void LoadBtn()
        {
            //파일 저장된 것 불러오는 코드 작성할 것
        }

        public void ExitBtn()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }

        public void CreatePlayer(int index)
        {
            var sdChar = GameManager.SD.sdCharacters.Where(_ => _.index == index).SingleOrDefault();

            var tmp = GameObject.Find("GameManager").GetComponent<GameManager>();
            tmp.myStats[0].index = sdChar.index;
            tmp.myStats[0].playerEXP = 0;
            tmp.myStats[0].playerLevel = 1;
            tmp.myStats[0].modeAccuracyStat = mode * sdChar.accuracy_stat;
            tmp.myStats[0].modeSpeedStat = mode * sdChar.speed_stat;
            tmp.myStats[0].modeCritStat = mode * sdChar.crit_stat;
            tmp.myStats[0].modeMinDamageStat = mode * sdChar.min_damage_stat;
            tmp.myStats[0].modeMaxDamageStat = mode * sdChar.max_damage_stat;
            tmp.myStats[0].modeEvasionStat = mode * sdChar.evasion_stat;
            tmp.myStats[0].NpcCamp = sdChar.camp;
            tmp.playerCount++;

        }
    }
}
