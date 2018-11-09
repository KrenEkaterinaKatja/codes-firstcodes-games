using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour {

	GameLogic gl;

	void Start () {
		gl = GameObject.Find ("GameLogic").GetComponent<GameLogic> ();
	}

	void Update () {
		
	}

	void OnTriggerEnter ( Collider c )
	{

		if (c.tag == "Player") {
			gl.Collect ();
			Destroy (gameObject);
		}
	}
}
