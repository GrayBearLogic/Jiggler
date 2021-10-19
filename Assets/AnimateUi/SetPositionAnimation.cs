using UnityEngine;

namespace AnimateUi
{
    public class SetPositionAnimation : ImmediateAnimation
    {
        private readonly Vector2 pos;
        private readonly RectTransform rt;

        public SetPositionAnimation(Animation previous, Vector2 pos) : base(previous)
        {
            this.pos = pos;
            this.rt = Target.GetComponent<RectTransform>();
        }

        protected override void DoAction()
        {
            rt.anchoredPosition = pos;
        }
    }
}