using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler : MonoBehaviour {

	public int countX = 8;
	public int countY = 8;
	public GameObject go;

	// Use this for initialization
	void Start () {
		if (go != null) {
			for (int x = 0; x < countX; x++) {
				for (int y = 0; y < countY; y++) {
					GameObject newGo;
					newGo = Instantiate (go);
					newGo.transform.position = new Vector3 (x, 0, y);
				}
					
			}
		
		} else {
			Debug.LogError ("No game object defined.");
		}


	}

	void Update () {
		
	}
}
