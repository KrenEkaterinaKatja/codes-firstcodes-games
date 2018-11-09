using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator: MonoBehaviour {

	public int muuttuja_A = 0;
	public int muuttuja_B = 1;
	public int muuttuja_C = 2;

	public List<int> numeroita = new List<int>();
	public List<GameObject> peliobjektit;

	// Use this for initialization
	void Start () 
	{
	
		/*for (int k = 100; k > 0; k--) {
			//Debug.Log (k);
			numeroita.Add(k);
		}
			

		foreach (GameObject g in peliobjektit) {
			g.transform.Translate (0, Random.value * 5, 0);
			//g.transform.position.y +- Random.value * 5;
			Debug.Log (g.transform.position);

		}
	 	*/

		#region IF EXAMPLES
			
		/*
		if (muuttuja_A > muuttuja_B) {
		Debug.Log ("On isompi.");
		}
		else if (muuttuja_A < muuttuja_B) { 
		Debug.Log ("Ei ole on isompi.");
		}
		else {        
		Debug.Log ("Ovat yhtä suuret.");
		}
	   if ( muuttuja_A != muuttuja_B) { 
		} 
		*/
		#endregion
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
