using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

namespace SlimUI.ModernMenu{
	public class HoverSoundPlayer : MonoBehaviour {
		[Header("SFX")]
		[Tooltip("The GameObject holding the Audio Source component for the HOVER SOUND")]
		public AudioSource hoverSound;

		public void PlayHover(){
			hoverSound.Play();
		}
	}
}