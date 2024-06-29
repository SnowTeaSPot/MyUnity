using AEA;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace Roguelike.Data
{
    public class PlayerFollow : MonoBehaviour
    {
        public GameObject followerTarget;    //따라갈 목표 대상 설정
        public int moveSpeed = 1;
        public float maintaindistance = 0.5f;

       
        private void Update()
        {

        }
    
        private void LateUpdate()
        {
            FollowMainPlayer();
        }

        void FollowMainPlayer()
        {
            Transform tmp = followerTarget.transform;
            transform.position = Vector2.MoveTowards(transform.position, followerTarget.transform.position, moveSpeed * Time.deltaTime); 
        }
    }
}