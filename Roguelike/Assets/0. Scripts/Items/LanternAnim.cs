using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Roguelike.Contents
{
    using State = Utill.Define.LanternState;
    public class LanternAnim : MonoBehaviour
    {
        public int oil = 100;
        private int lanternAnimState;
        Animator anim;
        public State lanternState { get; set; }

        void Start()
        {
            anim = GetComponent<Animator>();
            lanternAnimState = Animator.StringToHash("state");
            StartCoroutine(LanternUpdate());
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
            Debug.Log("나오고 있습니다.");
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

        private IEnumerator LanternUpdate()
        {
            while (true)
            {
                LanternControl();
                yield return new WaitForSeconds(5f);
            }
        }
    }
}
