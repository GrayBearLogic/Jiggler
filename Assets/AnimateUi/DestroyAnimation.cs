using System.Collections;
using UnityEngine;

namespace AnimateUi
{
    public class DestroyAnimation : ImmediateAnimation
    {
        public DestroyAnimation(Animation previous) : base(previous)
        {
        }

        protected override void DoAction()
        {
            Object.Destroy(Target);
        }
    }
}