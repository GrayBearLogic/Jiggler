namespace AnimateUi
{
    public class HideAnimation : ImmediateAnimation
    {
        public HideAnimation(Animation previous) : base(previous)
        {
        }

        protected override void DoAction()
        {
            Target.SetActive(false);
        }
    }
}