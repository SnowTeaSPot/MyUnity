using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRuleManager : MonoBehaviour
{
    public enum Playstate
    {
        start, playerTurn, enemyTurn, win, lose
    }

    public Playstate pstate;
    public bool PlayerIsLive;
    public bool enemyIsLive;

    void Awake()
    {
        pstate = Playstate.start;
        BattleStart();
    }

    void BattleStart()
    {
        //속도 기반으로 구현
        
    }

    void BattleEnd()
    {
        
    }

    void PlayerAttackBtn()
    {

        //버튼이 중복으로 눌리는 것을 방지하기 위함
        if(pstate != Playstate.playerTurn)
        {
            return;
        }
        StartCoroutine(PlayerAttack());
    }

    //코루틴 사용하는 이유는 플레이어가 공격한 후 바로 적이 공격하는 것을 방지하기 위함
    IEnumerator PlayerAttack()
    {
        yield return new WaitForSeconds(2.0f);
        Debug.Log($"플레이어가 공격");

        //공격 스킬 데미지 등을 갖고 올 것

        if (!enemyIsLive)
        {
            pstate = Playstate.win;
            BattleEnd();
        }
        else
        {
            pstate = Playstate.enemyTurn;
            StartCoroutine(EnemyAttack());
        }
    }

    IEnumerator EnemyAttack()
    {
        yield return new WaitForSeconds(1.0f);
        Debug.Log("적이 공격");

        //적 공격 코드

        if(!PlayerIsLive)
        {
            pstate = Playstate.lose;
            BattleEnd();
        }       
        else
        {
            pstate = Playstate.playerTurn;
        }
    }
}
