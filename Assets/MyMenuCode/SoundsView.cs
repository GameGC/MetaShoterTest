using UnityEngine;
using UnityEngine.UI;

namespace MyMenuCode
{
    public class SoundsView : MonoBehaviour
    {
        [SerializeField] private Slider soundSlider;
        [SerializeField] private AudioSource audioSource;

        private void OnEnable()
        {
            soundSlider.value = PlayerPrefs.GetFloat("MusicVolume");
            audioSource.volume = soundSlider.value;
            soundSlider.onValueChanged.AddListener(OnSoundSliderChanged);
        }
        private void OnSoundSliderChanged(float value)
        {
            PlayerPrefs.SetFloat("MusicVolume",value);
            audioSource.volume = value;
        }

        private void OnDisable() => soundSlider.onValueChanged.RemoveListener(OnSoundSliderChanged);
    }
}