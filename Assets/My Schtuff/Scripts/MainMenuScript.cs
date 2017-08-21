using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
//----------------------------------------------------------------------//
public class MainMenuScript : MonoBehaviour {
//----------------------------------------------------------------------//
	public GameObject SettingsPanel;
	public GameObject MenuPanel;
	public AudioClip ClickSound;
	public GameObject CreditsPanel;
	public AudioSource source;
//----------------------------------------------------------------------//
// Initializing
	void Start () {
		SettingsPanel.SetActive (false);
		CreditsPanel.SetActive (false);
	}
//----------------------------------------------------------------------//
// Start button function
	public void startButton () {
		SceneManager.LoadSceneAsync ("Game");
		source.PlayOneShot (ClickSound, 20.0f);
	}
//----------------------------------------------------------------------//
// Settings button function
	public void settingsButton () {
		SettingsPanel.SetActive (true);
		MenuPanel.SetActive (false);
		source.PlayOneShot (ClickSound, 20.0f);
	}
//----------------------------------------------------------------------//
// Credits button function
	public void creditsButton () {
		MenuPanel.SetActive (false);
		CreditsPanel.SetActive (true);
		source.PlayOneShot (ClickSound, 20.0f);
	}
//----------------------------------------------------------------------//
// Quit button function
	public void quitButton () {
		Application.Quit ();
		source.PlayOneShot (ClickSound, 20.0f);
	}
//----------------------------------------------------------------------//
}
