using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour {
	GameLogic gl;

	Rigidbody r;
	public float MovementPower = 20f;

	void Start () {

		r = GetComponent<Rigidbody>();
		gl = GameObject.Find ("GameLogic").GetComponent<GameLogic> ();

	}

	void Update () {

		if (gl.GetGameState () == GameLogic.GAME_STATE_IN_GAME) {
			Vector3 v = new Vector3 (Input.GetAxis ("Horizontal")* ( Time.deltaTime * MovementPower) ,
				0,
				Input.GetAxis ("Vertical") * (Time.deltaTime * MovementPower));
			r.AddForce (v);
			
		}

	}
}
