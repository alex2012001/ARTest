using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ARTest.UI
{
    public class UICanvas : MonoBehaviour
    {
        [SerializeField] private Button restartButton;
        [SerializeField] private Button useButton;

        private Action _onUseButtonClick;
        
        public void SetActiveUseButton(bool value, Action onUseButtonClick = null)
        {
            useButton.gameObject.SetActive(value);

            if (value)
            {
                _onUseButtonClick = onUseButtonClick;
            }
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
            _onUseButtonClick?.Invoke();
        }
    }
}
