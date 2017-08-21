using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//----------------------------------------------------------------------//
public class PlayerController : MonoBehaviour {
//----------------------------------------------------------------------//
	public float speed;
	private Rigidbody rb;
	private int count;
	public Text countText;
	public Canvas PauseMenu;
	public float height;
	public Camera Camera;
	public GameObject WinPanel;
//----------------------------------------------------------------------//
// For Initializing
	void Start () {
		PauseMenu.enabled = false;
		Time.timeScale = 1;
		rb = GetComponent<Rigidbody> ();
		count = 0; 
		setCountText ();
		WinPanel.SetActive (false);
	}
//----------------------------------------------------------------------//
// Updates every frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (PauseMenu.enabled == false) {
				Time.timeScale = 0;
				PauseMenu.enabled = true;
			} 
			else {
				Time.timeScale = 1;
				PauseMenu.enabled = false;
			}
		}
		if (PauseMenu.enabled == false){
			if (WinPanel.activeInHierarchy == false) {
				Camera.transform.Rotate (new Vector3 (-Input.GetAxis("Mouse Y"), 0.0f, 0.0f));
			}
		}
	}
//----------------------------------------------------------------------//
// Updates every T=const
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 jump = new Vector3 (0.0f, 2.5f, 0.0f);
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
		if (Input.GetKeyDown(KeyCode.Space)) {
			rb.AddForce (jump * height); 
		}

	}
//----------------------------------------------------------------------//
// Called When 'Collider' and 'other' collide
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("pickup")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			setCountText ();
		}
	}
//----------------------------------------------------------------------//
//TextCounter function
	void setCountText () {
			countText.text = "Count: " + count.ToString ();
		if (count >= 14) {
			WinPanel.SetActive (true);
			Time.timeScale = 0;

		}
	}
//----------------------------------------------------------------------//
}
