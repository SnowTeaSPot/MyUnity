using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingleTon<GameManager>
{
    public int CurrentScene;
    public int PreviousScene;
    public Transform playerTrans;

    [SerializeField]
    private SDlist sd = new SDlist();


    public static SDlist SD
    {
        get
        {
            return Instance.sd;
        }
    }

    void NowLoadScene()
    {
        if (SceneManager.GetActiveScene().name == "StageDemo")
        {

        }
        else if (SceneManager.GetActiveScene().name == "FightScene")
        {

        }
    }
}
