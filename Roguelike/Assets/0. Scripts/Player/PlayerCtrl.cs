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
        [SerializeField] float moveSpeed;
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

        }

        void Update()
        {
            PlayerMovement();
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

                case State.isFallandGround:

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
            rig.velocity = new Vector2(x * moveSpeed, rig.velocity.y);
            
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

            if (x != 0)
            {
                SetState(State.isWalk);
            }

            if (x != 0 && Input.GetKey(KeyCode.LeftShift))
            {
                SetState(State.isSlide);
            }

            if (x == 0 && State != State.isFallandGround)
            {
                SetState(State.isIdle);
            }
        }

        void PlayerJump()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                rig.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            }

            if( rig.velocity.y > 0 ) 
            {
                SetState(State.isJump);
            }
            if (rig.velocity.y < 0 )
            {
                SetState(State.isFalling);
            }
        }


        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Platform"))
            {
                PisJump = false;
                PisGround = true;
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