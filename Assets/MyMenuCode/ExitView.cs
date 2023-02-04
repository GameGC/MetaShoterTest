using UnityEngine;
using UnityEngine.UI;

namespace MyMenuCode
{
    public class ExitView : MonoBehaviour
    {
        [SerializeField] private Button showExitMenuButton;

        [SerializeField] private GameObject exitMenu;
        [SerializeField] private Button confirmExitButton;
        [SerializeField] private Button declineExitButton;


        private void OnEnable()
        {
            showExitMenuButton.onClick.AddListener(ShowExitMenu);
            declineExitButton.onClick .AddListener(HideExitMenu);
            confirmExitButton.onClick .AddListener(DoExit);
        }

        private void ShowExitMenu() => exitMenu.SetActive(true);
        private void HideExitMenu() => exitMenu.SetActive(false);
    
        private void DoExit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
        }

        private void OnDisable()
        {
            showExitMenuButton.onClick.RemoveListener(ShowExitMenu);
            declineExitButton.onClick.RemoveListener(HideExitMenu);
            confirmExitButton.onClick.RemoveListener(DoExit);
        }
    }
}