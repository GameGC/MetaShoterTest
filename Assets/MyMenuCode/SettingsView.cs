using UnityEngine;
using UnityEngine.UI;

namespace MyMenuCode
{
    public class SettingsView : MonoBehaviour
    {
        public Button settingsMenuButton;
        public Button returnToMainMenuButton;
        public Animator canvasAnimator;


        private void OnEnable()
        {
            settingsMenuButton.onClick.AddListener(ShowSettingsMenu);
            returnToMainMenuButton.onClick.AddListener(HideSettingsMenu);
        }

        private void ShowSettingsMenu() => canvasAnimator.SetFloat("Animate",1);
        private void HideSettingsMenu() => canvasAnimator.SetFloat("Animate",0);

    

    
    
    
        private void OnDisable()
        {
            settingsMenuButton.onClick.RemoveListener(ShowSettingsMenu);
            returnToMainMenuButton.onClick.RemoveListener(HideSettingsMenu);
        }
    }
}