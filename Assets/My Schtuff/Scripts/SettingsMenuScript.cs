using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
//----------------------------------------------------------------------//
public class SettingsMenuScript : MonoBehaviour {
//----------------------------------------------------------------------//
	public GameObject SettingsMenu;
	public GameObject MainMenu;
	public AudioClip ClickSound;
	public AudioSource source;
//----------------------------------------------------------------------//
// Back button function
	public void backButton () {
		MainMenu.SetActive (true);
		SettingsMenu.SetActive (false);
		source.PlayOneShot (ClickSound, 20.0f);
	}
//----------------------------------------------------------------------//
// Updates every frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			MainMenu.SetActive (true);
			SettingsMenu.SetActive (false);
		}
	}
//----------------------------------------------------------------------//
}
