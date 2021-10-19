using System;
using UnityEngine;

namespace AnimateUi
{
    public class AnimationPlayer : MonoBehaviour
    {
        public static AnimationPlayer Player
        {
            get;
            private set;
        }

        private void Awake()
        {
            Player = this;
        }
    }
}