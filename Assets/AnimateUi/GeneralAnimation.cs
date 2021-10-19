using System.Collections;

namespace AnimateUi
{
    public abstract class GeneralAnimation : Animation
    {
        private readonly Animation previous;
        
        protected GeneralAnimation(Animation previous) : base(previous.Target)
        {
            this.previous = previous;
        }

        public override IEnumerator Execute()
        {
            yield return previous.Execute();
        }
    }
}