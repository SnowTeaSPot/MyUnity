using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UICharStat : MonoBehaviour
{
    public Text charIndex;
    public Text charSpeedData;
    public void ShowStat(int index)
    {
        //_는 sdCharacters에서 뭐가 들어올지 모르기에 _로 사용하면 들어온 애를 받아서 그 캐릭터의 index가 변수와 같으면 데이터를 가져온다
        var sdcharacter = GameManager.SD.sdCharacters.Where(_ => _.index == index).SingleOrDefault();
        //Debug.Log($"해당 캐릭터의 SpeedStat = {sdcharacter.speed_stat}");
        charIndex.text = $"{sdcharacter.index}";
    }
    
    // Start is called before the first frame update
    void Start()
    {
        ShowStat(1000);
    }
}
