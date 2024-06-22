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
        //�ӵ� ������� ����
        
    }

    void BattleEnd()
    {
        
    }

    void PlayerAttackBtn()
    {

        //��ư�� �ߺ����� ������ ���� �����ϱ� ����
        if(pstate != Playstate.playerTurn)
        {
            return;
        }
        StartCoroutine(PlayerAttack());
    }

    //�ڷ�ƾ ����ϴ� ������ �÷��̾ ������ �� �ٷ� ���� �����ϴ� ���� �����ϱ� ����
    IEnumerator PlayerAttack()
    {
        yield return new WaitForSeconds(2.0f);
        Debug.Log($"�÷��̾ ����");

        //���� ��ų ������ ���� ���� �� ��

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
        Debug.Log("���� ����");

        //�� ���� �ڵ�

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
