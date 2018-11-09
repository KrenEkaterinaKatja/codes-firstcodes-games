using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseHandler : MonoBehaviour {

	bool isGamePaused = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Escape))
			isGamePaused = !isGamePaused;

		if (isGamePaused)
			Time.timeScale = 0.5f; // MUOKATTU: pausille niin riittää 0, hitaasti liikkuviksi 0.5f jne
		else
			Time.timeScale = 1;

	}

	void OnGUI() {
		if (isGamePaused)
			GUI.Label (new Rect (10, 10, 100, 30), "PAUSED!");
	}
	
}
