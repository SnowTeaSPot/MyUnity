using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject uiPlayer = null;
    public GameObject uiTarget = null;
    public GameObject uiOption;

    private int escCheck = 0;
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "FightScene") CheckESC();
        //else if (SceneManager.GetActiveScene().name == "Stage01") BtnSetting();
    }

    void CheckESC()
    {
        if (Input.GetButtonUp("Cancel"))
        {
            escCheck++;
            if (escCheck % 2 == 1)
            {
                Time.timeScale = 0;
                uiPlayer.SetActive(false);
                uiTarget.SetActive(false);
                uiOption.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                escCheck = 0;
                uiPlayer.SetActive(true);
                uiTarget.SetActive(true);
                uiOption.SetActive(false);
            }
        }
    }

    //public void BtnSetting()
    //{
    //    uiOption.SetActive(true);

    //    if (Input.GetButtonUp("Cancel"))
    //    {
    //        uiOption.SetActive(false);
    //    }
    //}
}
