using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {
	
	public GameObject GameObjectToFollow;
	public Vector3 OffsetVector = new Vector3 (0, 7, -10);

	void Start () {
		
		if (GameObjectToFollow == null)
			Debug.LogError ("No Game Object To Follow.");
	}

	void Update () {
		transform.position = GameObjectToFollow.transform.position + OffsetVector;
	}
}
