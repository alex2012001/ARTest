using ARTest.SceneObjects.Effects.Realization;
using UnityEngine;

namespace ARTest.SceneObjects.Realization
{
    public class SphereView : SceneObject, IObjectWithEffects
    {
        public SetColorEffect SetColorEffect => setColorEffect;
        public OutlineEffect OutlineEffect => outlineEffect;
        
        [SerializeField] private SetColorEffect setColorEffect;
        [SerializeField] private OutlineEffect outlineEffect;
    }
}
