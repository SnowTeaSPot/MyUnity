using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Roguelike.Contents
{
    using State = Utill.Define.LanternState;
    public class LanternAnim : MonoBehaviour
    {
        public int oil;
        public float oilDecreaseTime = 0;
        private int lanternAnimState;
        Animator anim;
        public State lanternState { get; set; }

        void Start()
        {
            anim = GetComponent<Animator>();
            lanternAnimState = Animator.StringToHash("state");
        }

        void Update()
        {
            LanternOilDecrease();
        }

        public void SetLanternState(State state)
        {
            lanternState = state;
            anim.SetInteger(lanternAnimState, (int)state);
            switch (state)
            {
                case State.isFullOil:

                    break;

                case State.isHalfOil:

                    break;

                case State.isLowOil:

                    break;

                case State.isNoneOil:

                    break;
            }
        }

        public void LanternControl()
        {
            if (oil >= 75)
            {
                SetLanternState(State.isFullOil);
            }
            else if (oil < 75 && oil >= 25)
            {
                SetLanternState(State.isHalfOil);
            }
            else if (oil < 25 && oil > 0)
            {
                SetLanternState(State.isLowOil);
            }
            else
            {
                SetLanternState(State.isNoneOil);
            }
        }

        public void LanternOilDecrease()
        {
            if (oil > 0)
            {
                oilDecreaseTime += Time.deltaTime;

                if (oilDecreaseTime > 5)
                {
                    oil -= 1;
                    Debug.Log($"남은 기름 : {oil}");
                    oilDecreaseTime = 0;
                    LanternControl();
                }
            }
        }
    }
}
