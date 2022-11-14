using ARTest.AR;
using ARTest.SceneObjects;
using ARTest.UI;
using UnityEngine;

namespace ARTest.Application
{
    public class ApplicationStartup : MonoBehaviour
    {
        private SceneObjectsStorage _sceneObjectsStorage = new SceneObjectsStorage();

        private void Awake()
        {
           _sceneObjectsStorage.InitAndSpawnObjects(StartApplication);
        }

        private void StartApplication()
        {
            var uiHolder = _sceneObjectsStorage.Get<UIHolder>();
            if (uiHolder == null)
            {
                SendError(typeof(UIHolder).ToString());
                return;
            }
           
            var arView = _sceneObjectsStorage.Get<ARView>();
            if (arView == null)
            {
                SendError(typeof(ARView).ToString());
                return;
            }
            
            arView.EffectsRaycaster.StartRaycast(uiHolder.UICanvas);
            
            Destroy(gameObject);
        }

        private void SendError(string objType)
        {
            Debug.LogError($"Object with type {objType} was not spawned");
        }
    }
}
