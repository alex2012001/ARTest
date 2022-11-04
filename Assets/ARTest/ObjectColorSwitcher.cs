using UnityEngine;

namespace ARTest
{
    public class ObjectColorSwitcher : MonoBehaviour
    {
        [SerializeField] private MeshRenderer meshRenderer;
        
        private static readonly int Color = Shader.PropertyToID("_Color");
        private static readonly int Width = Shader.PropertyToID("_OtlWidth");
        
        private const float WidthMaxValue = 5f;

        public void SetColor(Color color)
        {
            meshRenderer.material.SetColor(Color, color);
        }

        public void SetOutLine(bool value)
        {
            if (value)
            {
                meshRenderer.material.SetFloat(Width, WidthMaxValue);
                return;
            }
            
            meshRenderer.material.SetFloat(Width, 0f);
        }
    }
}
