using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxSpeed;
    [SerializeField] float jumpPower;
    SpriteRenderer renderer;
    Animator anim;
    Rigidbody2D rig;
    private bool isGround = true;
    private bool isRun = false;
    private bool isMove = false;
    private bool isJump = false;



    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
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

    // Update is called once per frame
    void Update()
    {

        if (rig.velocity.x > maxSpeed)
        {
            rig.velocity = new Vector2(maxSpeed, rig.velocity.y);
        }
        else if (rig.velocity.x < -maxSpeed)
        {
            rig.velocity = new Vector2(-maxSpeed, rig.velocity.y);
        }

        if (rig.velocity.x != 0 && isMove == false)
        {
            isMove = true;
            anim.SetBool("IsMove", isMove);
        }
        else if(rig.velocity.x == 0 && isMove == true)
        {
            isMove = false;
            anim.SetBool("IsMove", isMove);
        }



        if (Input.GetKeyDown(KeyCode.W) && isGround == true)
        {
            isGround = false;
            isJump = true;
            rig.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            anim.SetBool("IsGround", isGround);
            anim.SetBool("IsJump", isJump);
        }


        if (Input.GetKey(KeyCode.LeftShift) && isMove == true)
        {
            isRun = true;
            maxSpeed = 10;
            anim.SetBool("IsRun", isRun);
        }
        else if (Input.GetKey(KeyCode.LeftShift) && isMove == true)
        {
            isRun = false;
            maxSpeed = 15;
            anim.SetBool("IsRun", isRun);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Platform"))
        {
            isGround = true;
            isJump = false;
            anim.SetBool("IsGround", isGround);
            anim.SetBool("IsJump", isJump);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Platform"))
        {
            isGround = false;
            anim.SetBool("IsGround", isGround);
        }
    }
}
