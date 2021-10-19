namespace AnimateUi
{
    public class ShowAnimation : ImmediateAnimation
    {
        public ShowAnimation(Animation previous) : base(previous)
        {
        }

        protected override void DoAction()
        {
            Target.SetActive(true);
        }
    }
}