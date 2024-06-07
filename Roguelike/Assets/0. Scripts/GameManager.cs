using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

}
