using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.U2D.Path;
using UnityEngine;

namespace Roguelike.Title
{
    using Player = Data.GameData;
    public enum ClassType { Archemist, Knight, Priest, Thief }
    public class TitleBtns : MonoBehaviour
    {
        [SerializeField]
        public SDCharacter[] sdCharDB;
        public int mode;
        public Player pl { get; set; }
        public void NewBtn()
        {
            CreatePlayerOnce(ClassType.Priest);
            CreatePlayerOnce(ClassType.Knight);
            CreatePlayerOnce(ClassType.Thief);
        }

        public void LoadBtn()
        {

        }

        public void ExitBtn()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }

        public void CreatePlayerOnce(ClassType inputClassType)
        {
            //Resources.Load<>

            //if (pl.index[inputClassType.] != null)
            //pl.index[sdCharDB[inputClassType].] = 
        }
    }
}
