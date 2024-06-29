using Roguelike.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingleTon<GameManager>
{
    public int CurrentScene;
    public int PreviousScene;
    public int playerCount = 0;
    public Transform playerTrans;

    [SerializeField]
    private SDlist sd = new SDlist();

    public PlayerData[] myStats = new PlayerData[10];
    public static SDlist SD
    {
        get
        {
            return Instance.sd;
        }
    }


    void NowLoadScene()
    {
        if (SceneManager.GetActiveScene().name == "Stage01")
        {

        }
        else if (SceneManager.GetActiveScene().name == "FightScene")
        {

        }
    }
}
