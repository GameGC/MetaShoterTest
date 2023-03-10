using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MyMenuCode
{
    public class PlayView : MonoBehaviour
    {
        [SerializeField] private Button playButton;
        [SerializeField] private int levelIndex = 1;


        private void OnEnable() => playButton.onClick.AddListener(DoPlay);

        private void DoPlay() => SceneManager.LoadScene(levelIndex);

        private void OnDisable() => playButton.onClick.RemoveListener(DoPlay);
    }
}