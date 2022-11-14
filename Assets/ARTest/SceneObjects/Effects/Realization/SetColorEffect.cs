using UnityEngine;
using Random = UnityEngine.Random;

namespace ARTest.SceneObjects.Effects.Realization
{
    public class SetColorEffect : MonoBehaviour, IEffect
    {
        [SerializeField] private MeshRenderer meshRenderer;
        
        private static readonly int Color = Shader.PropertyToID("_Color");
        
        public void Do(bool value)
        {
            var color = new Color(
                Random.Range(0f,1f), 
                Random.Range(0f,1f), 
                Random.Range(0f,1f));
            
            meshRenderer.material.SetColor(Color, color);
        }
    }
}
