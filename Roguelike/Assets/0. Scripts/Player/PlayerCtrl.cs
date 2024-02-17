using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxSpeed;
    [SerializeField] float jumpPower;
    [SerializeField] float rigvely;
    SpriteRenderer renderer;
    Animator anim;
    Rigidbody2D rig;
    private bool PisGround = true;
    private bool PisJump = false;
    private int JumpCount = 0;
    private

    enum PlayerState
    {
        isIdle,
        isFallandGround,
        isWalk,
        isSlide,
        isJump,
        isFalling,
        isAttack
    }

    PlayerState CurrState = PlayerState.isIdle;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        renderer = GetComponentInChildren<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(x * speed, rig.velocity.y);

        if (x > 0)
        {
            renderer.flipX = false;
        }
        if (x < 0)
        {
            renderer.flipX = true;
        }
    }

    void Update()
    {
        PlayerMaxSpeed();
        SetAnim();
        //StartCoroutine(IsPlayerDead());
        //if(state == PlayerState.IsDead)
        //StopCoroutine(IsPlayerDead());
        rigvely = rig.velocity.y;
    }

    void PlayerMaxSpeed()
    {
        //속도 제한
        {
            if (rig.velocity.x > maxSpeed)
            {
                rig.velocity = new Vector2(maxSpeed, rig.velocity.y);
            } else if (rig.velocity.x < -maxSpeed)
            {
                rig.velocity = new Vector2(-maxSpeed, rig.velocity.y);
            }
        }
    }

    void SetAnim()
    {
        switch (CurrState)
        {
            case PlayerState.isIdle:
                if (CurrState == PlayerState.isIdle)
                    break;
                SetState(0);
                break;
            case PlayerState.isFallandGround:
                if (CurrState == PlayerState.isFallandGround)
                    break;
                SetState(1);
                break;
            case PlayerState.isWalk:
                if (CurrState == PlayerState.isWalk)
                    break;
                SetState(2);
                break;
            case PlayerState.isSlide:
                if (CurrState == PlayerState.isSlide)
                    break;
                SetState(3);
                break;
            case PlayerState.isJump:
                if (CurrState == PlayerState.isJump)
                    break;
                SetState(4);
                break;
            case PlayerState.isFalling:
                if (CurrState == PlayerState.isFalling)
                    break;
                SetState(5);
                break;
            case PlayerState.isAttack:
                if (CurrState == PlayerState.isAttack)
                    break;
                break;
            default:
                break;
        }
    }

    void SetState(int index)
    {
        //걷는 애니메이션 관리
        if (index == 0)
        {
            if (rig.velocity.x == 0 && rig.velocity.y == 0 && PisGround && PisJump )
            {
                anim.Play("Idle");
            }
        }
        //착지 애니메이션 관리
        else if (index == 1)
        {
            if (!PisJump && PisGround && rig.velocity.y == 0)
            {
                anim.Play("FallandGround");
            }
        } else if (index == 2)
        {
            if (rig.velocity.x != 0 && PisGround)
            {
                anim.Play("Walk");
            }
        } else if (index == 3)
        {
            if (Input.GetKey(KeyCode.LeftShift) && CurrState == PlayerState.isWalk && PisGround == true)
            {
                rig.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                maxSpeed = 30;
                anim.Play("Slide");
            }
        } else if (index == 4)
        {
            if (Input.GetKeyDown(KeyCode.W) && PisGround == true)
            {
                PisJump = true;
                anim.Play("Jump");
            }
        } else if (index == 5)
        {
            if (PisJump && !PisGround && CurrState == PlayerState.isJump && rig.velocity.y < 0)
            {
                anim.Play("Fall");
            }
        }
    }

    void PlayerAttackRange()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Platform"))
        {
            PisGround = true;
            PisJump = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Platform"))
        {
            PisGround = false;
            anim.SetBool("IsGround", PisGround);
        }
    }
}
