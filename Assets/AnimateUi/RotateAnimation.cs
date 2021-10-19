using UnityEngine;

namespace AnimateUi
{
    public class RotateAnimation : InterpolationAnimation
    {
        private float initAngle;
        private readonly float angle;
        private readonly RectTransform rt;
        
        public RotateAnimation(Animation previous, float angle, float duration) : base(previous, duration)
        {
            this.angle = angle;
            rt = Target.GetComponent<RectTransform>();
        }

        protected override void SaveValues()
        {
            initAngle = rt.rotation.eulerAngles.z;
        }

        protected override void Step(float proportion)
        {
            rt.rotation = Quaternion.Euler(0, 0, initAngle + angle * proportion);
        }
    }
}