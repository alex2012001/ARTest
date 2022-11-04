using UnityEngine;

namespace ARTest
{
    public class ObjectColorSwitcher : MonoBehaviour
    {
        [SerializeField] private Material material;
        
        private static readonly int Color = Shader.PropertyToID("_Color");

        public void SetColor(Color color)
        {
            material.SetColor(Color, color);
        }
    }
}
