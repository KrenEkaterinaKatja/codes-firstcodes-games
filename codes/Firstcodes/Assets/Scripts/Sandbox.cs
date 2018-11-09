using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandbox : MonoBehaviour {
	bool b;
	bool c = false;

	public int i;
	public int k = 54321;
	int maxLives = 5;
	int playerLives;

	float f;
	float positionX = 15f; 
	float positionY = 9.24f;

	string s;
	string teksti = "Teksti.";


	void Start () {
		int newNumber = Sum (i, k);
		i = 3;
		Debug.Log ("Integerit:" + (i + k) );
		//Debug.Log ("Integerit:" + i + k );
		Debug.Log ("NewNumber:" + newNumber );
		
	}

	void Update () {
		
	}
		
	int Sum( int x, int y) {
		return x + y;
	}
}
