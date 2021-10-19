using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AnimateUi
{
    public class SetColorAnimation : ImmediateAnimation
    {
        private readonly Color color;
        private readonly Image image;
        public SetColorAnimation(Animation previous, Color color) : base(previous)
        {
            this.color = color;
            image = Target.GetComponent<Image>();
        }

        protected override void DoAction()
        {
            image.color = color;
        }
    }
}