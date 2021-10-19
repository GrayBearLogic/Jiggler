using System.Collections;

namespace AnimateUi
{
    public class ExternalAnimation : GeneralAnimation
    {
        private readonly Animation slave;
        
        public ExternalAnimation(Animation previous, Animation slave) : base(previous)
        {
            this.slave = slave;
        }

        public override IEnumerator Execute()
        {
            yield return base.Execute();
            yield return slave.Execute();
        }
    }
}