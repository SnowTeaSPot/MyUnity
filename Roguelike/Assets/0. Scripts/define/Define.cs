using System;

namespace Roguelike.Utill
{
    public class Define
    {
        public enum PlayerState
        {
            isIdle,
            isFallandGround,
            isWalk,
            isSlide,
            isJump,
            isFalling,
            isAttack
        }
    }
}