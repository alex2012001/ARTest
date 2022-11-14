using ARTest.SceneObjects;
using ARTest.SceneObjects.Effects;
using UnityEngine;

namespace ARTest.AR
{
    public class ARView : SceneObject
    {
        public EffectsRaycaster EffectsRaycaster => effectsRaycaster;
        
        [SerializeField] private EffectsRaycaster effectsRaycaster;
    }
}
