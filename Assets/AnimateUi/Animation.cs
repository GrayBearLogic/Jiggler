using System.Collections;
using UnityEngine;

namespace AnimateUi
{
    public abstract class Animation
    {
        protected internal readonly GameObject Target;
        
        protected Animation( GameObject target)
        {
            Target = target;
        }

        public static Animation For(GameObject target)
        {
            return new StartAnimation(target);
        }
        
        public void Run()
        {
            AnimationPlayer.Player.StartCoroutine(Execute());
        }

        public abstract IEnumerator Execute();


        public Animation Wait(float duration)
        {
            return new WaitAnimation(this, duration);
        }
        public Animation Move(Vector2 offset, float duration)
        {
            return new MoveAnimation(this, offset, duration);
        }
        public Animation Rotate(float angle, float duration)
        {
            return new RotateAnimation(this, angle, duration);
        }
        public Animation Scale(float factor, float duration)
        {
            return new ScaleAnimation(this, factor, duration);
        }

        public Animation SetPositon(Vector2 point)
        {
            return new SetPositionAnimation(this, point);
        }
        public Animation SetScale(float factor)
        {
            return new SetScaleAnimation(this, factor);
        }
        public Animation SetText(string text)
        {
            return new SetTextAnimation(this, text);
        }
        public Animation SetColor(Color color)
        {
            return new SetColorAnimation(this, color);
        }
        
        public Animation Hide()
        {
            return new HideAnimation(this);
        }
        public Animation Show()
        {
            return new ShowAnimation(this);
        }

        public Animation Destroy()
        {
            return new DestroyAnimation(this);
        }

        public Animation Then(Animation next)
        {
            return new ExternalAnimation(this, next);
        }
        public Animation ThenMany(params Animation[] animations)
        {
            return new ParallelAnimation(this, animations);
        }
    }
}
