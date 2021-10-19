using System.Collections;
using UnityEngine;

namespace AnimateUi
{
    public class StartAnimation : Animation
    {
        
        public StartAnimation(GameObject taget) : base(taget)
        {
        }
        
        public override IEnumerator Execute()
        {
            yield return null;
        }
    }
}