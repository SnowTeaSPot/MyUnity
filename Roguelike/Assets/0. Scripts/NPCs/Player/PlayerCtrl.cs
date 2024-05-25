using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Roguelike.Contents
{
    using State = Utill.Define.PlayerState;

    public class PlayerCtrl : MonoBehaviour
    {
        public float moveSpeed;
        public float realSpeed;
        [SerializeField] float maxSpeed;
        [SerializeField] float jumpPower;
        [SerializeField] float rigvely;
        SpriteRenderer ren;
        Animator anim;
        Rigidbody2D rig;
        private bool PisGround = true;
        private bool PisJump = false;
        private int JumpCount = 0;
        private int animState;
        public State State { get; set; }

        void Start()
        {
            rig = GetComponentInChildren<Rigidbody2D>();
            anim = GetComponentInChildren<Animator>();
            ren = GetComponentInChildren<SpriteRenderer>();
            animState = Animator.StringToHash("state");
        }

        void FixedUpdate()
        {
            PlayerMovement();
        }

        void Update()
        {
        PlayerJump();
        }

        public void SetState(State state)
        {
            State = state;
            anim.SetInteger(animState, (int)state);
            switch (state)
            {
                case State.isIdle:

                    break;

                case State.isWalk:

                    break;

                case State.isSlide:

                    break;

                case State.isJump:

                    break;

                case State.isFalling:

                    break;

                case State.isAttack:

                    break;

            }
        }

        void PlayerMovement()
        {
            float x = Input.GetAxis("Horizontal");
            rigvely = x;
            realSpeed = x * moveSpeed;
            rig.velocity = new Vector2(realSpeed, rig.velocity.y);
            
            {
                if (x > 0)
                {
                    ren.flipX = false;
                }
                if (x < 0)
                {
                    ren.flipX = true;
                }
            }

            if (x != 0 && PisGround)
            {
                SetState(State.isWalk);
            }

            if (x != 0 && Input.GetKey(KeyCode.LeftShift))
            {
                SetState(State.isSlide);
            }

            if (x == 0 && PisGround == true)
            {
                SetState(State.isIdle);
            }
        }

        void PlayerJump()
        {
            if (Input.GetKeyDown(KeyCode.W) && PisGround == true)
            {
                rig.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                PisGround = false;
                SetState(State.isJump);
            }
            
            if (rig.velocity.y < 0 )
            {
                SetState(State.isFalling);
            }

            if (rig.velocity.y == 0)
                PisGround = true;
        }


        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Platform"))
            {
                PisJump = false;
                PisGround = true;
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                SceneManager.LoadScene("FightScene");
            }
        }

        void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Platform"))
            {
                PisGround = false;
            }
        }
    }
}