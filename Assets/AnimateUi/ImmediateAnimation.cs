using System.Collections;

namespace AnimateUi
{
    public abstract class ImmediateAnimation : GeneralAnimation
    {
        protected ImmediateAnimation(Animation previous) : base(previous)
        {
        }

        public override IEnumerator Execute()
        {
            yield return base.Execute();
            DoAction();
            yield return null;
        }

        protected abstract void DoAction();
    }
}