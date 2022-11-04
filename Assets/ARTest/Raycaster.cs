using UnityEngine;

namespace ARTest
{
    public class Raycaster : MonoBehaviour
    {
        [SerializeField] private UICanvas uiCanvas;

        private ObjectColorSwitcher _colorSwitcher;
        
        private void Update()
        {
            if (Physics.Raycast(transform.position, transform.forward, out var raycastHit))
            {
                _colorSwitcher = raycastHit.collider.gameObject.GetComponent<ObjectColorSwitcher>();
                
                if (_colorSwitcher!=null)
                {
                    _colorSwitcher.SetOutLine(true);
                    uiCanvas.SetActiveUseButton(true, _colorSwitcher);
                }
            }
            else
            {
                if (_colorSwitcher != null)
                {
                    _colorSwitcher.SetOutLine(false);
                }
                
                uiCanvas.SetActiveUseButton(false);
            }
        }
    }
}
