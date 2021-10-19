using System.Collections;
using System.Linq;

namespace AnimateUi
{
    public class ParallelAnimation : GeneralAnimation
    {
        private readonly Animation[] slaves;
        
        public ParallelAnimation(Animation previous, Animation[] slaves) : base(previous)
        {
            this.slaves = slaves;
        }

        public override IEnumerator Execute()
        {
            yield return base.Execute();

            var enumerators = slaves.Select(animation => animation.Execute()).ToList();

            while (enumerators.Any())
            {
                for (var i = 0; i < enumerators.Count; i++)
                {
                    if (! enumerators[i].MoveNext())
                    {
                        enumerators.Remove(enumerators[i--]);
                    }
                }

                yield return null;
            }

        }
    }
}