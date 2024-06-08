using System;

namespace Roguelike.Utill
{
    public class Define
    {
        public enum PlayerState
        {
            isIdle,
            isWalk,
            isSlide,
            isAttack
        }

        public enum LanternState
        {
            isFullOil,
            isHalfOil,
            isLowOil,
            isNoneOil
        }
    }
}