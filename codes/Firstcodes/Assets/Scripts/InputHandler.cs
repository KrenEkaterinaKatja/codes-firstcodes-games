using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {


	public GameObject go;
	bool button_1_down = false;
	int numberCounter = 0;
	float hValue = 0;
	float vValue = 0;
	float zValue = 0;

	void Start () {
		if (go == null) {
			Debug.LogError ("No Game Object defined.");
		}
			
	}
		
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			button_1_down = true;
		} else if (Input.GetKeyUp (KeyCode.Space)) {
			button_1_down = false;
		}

		if (Input.GetKey (KeyCode.P))
			Count (51);
		
		if (Input.GetKeyUp (KeyCode.R))
			Reset ();

		hValue = Input.GetAxis ("Horizontal");
		vValue = Input.GetAxis ("Vertical");
		zValue = Input.GetAxis ("Z");
		go.transform.Translate( new Vector3(hValue, vValue, zValue ));

		if (go.transform.position.x < -5) {
			go.transform.position = new Vector3 (-5, 
				go.transform.position.y,
				go.transform.position.z);
		}
		
	}

	void OnGUI(){
		GUI.Label (new Rect (10, 10, 200, 30), "Input Data:");
		if (button_1_down) GUI.Label (new Rect (10, 40, 200, 30), "***SPACE***");
		GUI.Label (new Rect (10, 70, 200, 30), numberCounter.ToString());
		GUI.Label (new Rect (10, 100, 200, 30), hValue.ToString("f3")); 
	}

	void Count(int i) {
		numberCounter += i;
	}

	void Reset() {
		numberCounter = 0;
	}
}
