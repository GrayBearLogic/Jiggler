using System.Collections;
using UnityEngine;

namespace AnimateUi
{
    public abstract class InterpolationAnimation : GeneralAnimation
    {
        private readonly float duration;
        
        protected InterpolationAnimation(Animation previous, float duration) : base(previous)
        {
            this.duration = duration;
        }

        public override IEnumerator Execute()
        {
            yield return base.Execute();
            SaveValues();

            for (var time = 0f; time < duration; time+= Time.deltaTime)
            {
                Step(time / duration);
                yield return null;
            }
            Step(1);
            yield return null;
        }

        protected abstract void SaveValues();
        protected abstract void Step(float proportion);

    }
}