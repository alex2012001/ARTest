using ARTest.SceneObjects.Realization;
using ARTest.UI;
using UnityEngine;

namespace ARTest.SceneObjects.Effects
{
    public class EffectsRaycaster : MonoBehaviour
    {
        private UICanvas _uiCanvas;
        private RaycastHit _raycastHit;
        private IObjectWithEffects _objectWithEffects;
        private bool _isNotStarted = true;
        
        public void StartRaycast(UICanvas uiCanvas)
        {
            _uiCanvas = uiCanvas;
            _isNotStarted = false;
        }
        
        private void FixedUpdate()
        {
            if (_isNotStarted)
            {
                return;
            }
            
            if (Physics.Raycast(transform.position, transform.forward, out _raycastHit))
            {
                _objectWithEffects = _raycastHit.collider.gameObject.GetComponent<IObjectWithEffects>();
                
                if (_objectWithEffects!=null)
                {
                    _uiCanvas.SetActiveUseButton(true, () =>
                    {
                        _objectWithEffects.SetColorEffect.Do(true);
                    });
                    _objectWithEffects.OutlineEffect.Do(true);
                }
            }
            else
            {
                if (_objectWithEffects != null)
                {
                    _objectWithEffects.OutlineEffect.Do(false);
                }
                
                _uiCanvas.SetActiveUseButton(false);
            }
        }
    }
}
