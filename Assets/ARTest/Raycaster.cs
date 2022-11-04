using UnityEngine;

namespace ARTest
{
    public class Raycaster : MonoBehaviour
    {
        [SerializeField] private UICanvas uiCanvas;

        private void Update()
        {
            if (Physics.Raycast(transform.position, transform.forward, out var raycastHit))
            {
                var colorSwitcher = raycastHit.collider.gameObject.GetComponent<ObjectColorSwitcher>();
                
                if (colorSwitcher!=null)
                {
                    uiCanvas.SetActiveUseButton(true, colorSwitcher);
                }
            }
            else
            {
                uiCanvas.SetActiveUseButton(false);
            }
        }
    }
}
