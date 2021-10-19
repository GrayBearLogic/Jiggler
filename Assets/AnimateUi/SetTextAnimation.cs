using TMPro;

namespace AnimateUi
{
    public class SetTextAnimation : ImmediateAnimation
    {
        private readonly TextMeshProUGUI label;
        private readonly string text;
        public SetTextAnimation(Animation previous, string text) : base(previous)
        {
            this.text = text;
            label = Target.GetComponent<TextMeshProUGUI>();
        }

        protected override void DoAction()
        {
            label.text = text;
        }
    }
}