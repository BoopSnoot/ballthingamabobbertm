using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
//----------------------------------------------------------------------//
public class CreditsScript : MonoBehaviour {
//----------------------------------------------------------------------//
	public AudioClip ClickSound;
	public GameObject MenuPanel;
	public GameObject CreditsPanel;
	public AudioSource source;
//----------------------------------------------------------------------//
// Updates every frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (CreditsPanel.activeInHierarchy) {
				MenuPanel.SetActive (true);
				CreditsPanel.SetActive (false);
			}
		}
	}
//----------------------------------------------------------------------//
// Back button function
	public void backButton () {
		MenuPanel.SetActive (true);
		CreditsPanel.SetActive (false);
		source.PlayOneShot (ClickSound, 20.0f);
	}
//----------------------------------------------------------------------//
}
