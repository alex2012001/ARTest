using ARTest.SceneObjects;
using UnityEngine;

namespace ARTest.UI
{
    public class UIHolder : SceneObject
    {
        public UICanvas UICanvas => uiCanvas;
        
        [SerializeField] private UICanvas uiCanvas;
    }
}
