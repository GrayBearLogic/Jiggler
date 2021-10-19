using UnityEngine;

namespace AnimateUi
{
    public class MoveAnimation : InterpolationAnimation
    {
        private Vector2 initPos;
        private readonly Vector2 offset;
        private readonly RectTransform rt;
        
        public MoveAnimation(Animation previous, Vector2 offset, float duration) : base(previous, duration)
        {
            rt = Target.GetComponent<RectTransform>();
            this.offset = offset;
        }

        protected override void SaveValues()
        {
            initPos = rt.anchoredPosition;
        }

        protected override void Step(float proportion)
        {
            rt.anchoredPosition = initPos + offset * proportion;
        }
    }
}