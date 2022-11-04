using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ARTest
{
    public class UICanvas : MonoBehaviour
    {
        [SerializeField] private Button restartButton;
        [SerializeField] private Button useButton;

        private ObjectColorSwitcher _colorSwitcher;
        
        public void SetActiveUseButton(bool value, ObjectColorSwitcher colorSwitcher = null)
        {
            _colorSwitcher = colorSwitcher;
            useButton.gameObject.SetActive(value);
        }
        
        private void OnEnable()
        {
            restartButton.onClick.AddListener(OnRestartButtonClickMessage);
            useButton.onClick.AddListener(OnUseButtonClickMessage);
        }

        private void OnDisable()
        {
            restartButton.onClick.RemoveListener(OnRestartButtonClickMessage);
            useButton.onClick.RemoveListener(OnUseButtonClickMessage);
        }

        private void OnRestartButtonClickMessage()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    
        private void OnUseButtonClickMessage()
        {
            if (_colorSwitcher == null)
            {
                return;
            }
            
            _colorSwitcher.SetColor(new Color(
                Random.Range(0f,1f), 
                Random.Range(0f,1f), 
                Random.Range(0f,1f)));
        }
    }
}
