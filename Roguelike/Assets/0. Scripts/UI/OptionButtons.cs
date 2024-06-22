using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButtons : MonoBehaviour
{
    public void SaveBtnOnClick()
    {
        GameObject.Find("GameManager").GetComponent<DataManager>().SaveGameData();
    }

    public void LoadBtnOnClick()
    {
        GameObject.Find("GameManager").GetComponent<DataManager>().LoadGameData();
    }

    public void ExitBtnOnClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    //public void SettingBtnOnClick()
    //{
    //    GameObject.Find("GameManager").GetComponent<UIManager>().BtnSetting();
    //}
}
