using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
//----------------------------------------------------------------------//
public class PauseMenuScript : MonoBehaviour {
//----------------------------------------------------------------------//
	public Canvas PauseMenu;
	public GameObject PauseMenuPanel;
	public GameObject SettingsMenuPanel;
	public AudioClip ClickSound;

	private AudioSource source;
//----------------------------------------------------------------------//
	void Awake () {
		source = GetComponent<AudioSource>();
	}
//----------------------------------------------------------------------//
// Initializing
	void Start () {
		SettingsMenuPanel.SetActive (false);
	}
//----------------------------------------------------------------------//
// Resume button function
	public void unPause () {
		PauseMenu.enabled = false;
		Time.timeScale = 1;
		source.PlayOneShot (ClickSound, 1.0f);
	}
//----------------------------------------------------------------------//
// Settings button function
	public void settingsMenu () {
		SettingsMenuPanel.SetActive (true);
		PauseMenuPanel.SetActive (false);
		source.PlayOneShot (ClickSound, 1.0f);
	}
//----------------------------------------------------------------------//
// Back to main menu button function
	public void mainMenu () {
		SceneManager.LoadSceneAsync ("MainMenu");
		source.PlayOneShot (ClickSound, 20.0f);
	}
//----------------------------------------------------------------------//
// Updates every frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SettingsMenuPanel.SetActive (false);
			PauseMenuPanel.SetActive (true);
		}
	}
//----------------------------------------------------------------------//
// Settings on/off function
	void settingsToggle () {
		if (SettingsMenuPanel.activeInHierarchy) {
			SettingsMenuPanel.SetActive (false);
		} 
		else {
			SettingsMenuPanel.SetActive (true);
		}
	}
//----------------------------------------------------------------------//
// Back button function
	public void backButton () {
		PauseMenuPanel.SetActive (true);
		settingsToggle ();
	}
//----------------------------------------------------------------------//
//Restart button function
	public void restartButton () {
		SceneManager.LoadScene ("Game");
	}
//----------------------------------------------------------------------//
}
