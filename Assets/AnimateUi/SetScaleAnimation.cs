using UnityEngine;

namespace AnimateUi
{
    public class SetScaleAnimation : ImmediateAnimation
    {

        private readonly float scaleFactor;
        private readonly RectTransform rt;

        public SetScaleAnimation(Animation previous, float scale) : base(previous)
        {
            scaleFactor = scale;
            rt = Target.GetComponent<RectTransform>();
        }

        protected override void DoAction()
        {
            rt.localScale = Vector3.one * scaleFactor;
        }
    }
}