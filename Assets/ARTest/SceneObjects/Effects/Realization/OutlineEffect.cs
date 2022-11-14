using QuickOutline.Scripts;
using UnityEngine;

namespace ARTest.SceneObjects.Effects.Realization
{
    public class OutlineEffect : MonoBehaviour, IEffect
    {
        [SerializeField] private float outlineValue;
        [SerializeField] private Outline outline;

        public void Do(bool value)
        {
            if (value)
            {
                outline.OutlineWidth = outlineValue;
            }
            else
            {
                outline.OutlineWidth = 0;
            }
        }
    }
}
