using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
//----------------------------------------------------------------------//
public class SoundScript : MonoBehaviour {
//----------------------------------------------------------------------//
	public AudioMixer AudioMixer;
//----------------------------------------------------------------------//
	// Music level function
	public void musicLvl (float musicLvl) {
		AudioMixer.SetFloat ("musicVol", musicLvl);
	}
//----------------------------------------------------------------------//
	// SFX level function
	public void sfxLvl (float sfxLvl) {
		AudioMixer.SetFloat ("sfxVol", sfxLvl);
	}
//----------------------------------------------------------------------//
}
