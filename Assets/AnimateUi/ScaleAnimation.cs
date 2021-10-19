using UnityEngine;

namespace AnimateUi
{
    public class ScaleAnimation : InterpolationAnimation
    {
        private readonly RectTransform rt;
        private Vector3 initScale;
        private readonly float scale;
        private Vector3 deltaScale;

        public ScaleAnimation(Animation previous, float scale, float duration) : base(previous, duration)
        {
            rt = Target.GetComponent<RectTransform>();
            this.scale = scale;
        }

        protected override void SaveValues()
        {
            initScale = rt.localScale;
            deltaScale = initScale * scale - initScale;
        }

        protected override void Step(float proportion)
        {
            rt.localScale = initScale + proportion * deltaScale;
        }
    }
}