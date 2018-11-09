using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {
	private int GAME_STATE;
	public const int GAME_STATE_WAITING_INPUT = 10;
	public const int GAME_STATE_IN_GAME = 20;
	public const int GAME_STATE_GAME_OVER = 30;

	List <GameObject> coins = new List <GameObject> ();
	int coinsCount = -1;
	int coinsCollected = -1;
	float gameTime = 0;

	void Start () {
		foreach (GameObject go in GameObject.FindGameObjectsWithTag ("Coin")) {
			coins.Add (go);
		}	

		coinsCount = coins.Count;
		coinsCollected = 0;

		GAME_STATE = GAME_STATE_WAITING_INPUT;
	}

	void Update () {

		switch (GAME_STATE) {
		case GAME_STATE_WAITING_INPUT:
			if (Input.anyKeyDown) {
				GAME_STATE = GAME_STATE_IN_GAME;
			}
			break;
		case GAME_STATE_IN_GAME:
			gameTime += Time.deltaTime;
			if (coinsCollected == coinsCount) {
				GAME_STATE = GAME_STATE_GAME_OVER;
			}
			break;
		case GAME_STATE_GAME_OVER:
			default:
			break;
		}
			
	}

	void OnGUI() {
		GUI.Label (new Rect (10, 10, 100, 30), 
			"Coins:" + coinsCollected.ToString () 
			+ "/" + coinsCount.ToString ());

		switch (GAME_STATE) {
		case GAME_STATE_WAITING_INPUT:
			GUI.Label (new Rect (10, 40, 100, 30), "Press any key to start");
			break;
		case GAME_STATE_IN_GAME:
				GUI.Label (new Rect (10, 40, 100, 30), "Time: " + gameTime.ToString ("f2"));
			break;
		case GAME_STATE_GAME_OVER:
			GUI.Label (new Rect (10, 40, 100, 30), "Nice! Your time was " + gameTime.ToString ("f2"));
			break;
		default:
			break;

		}
			
	}

	public void Collect() {
		coinsCollected++;
	}

	public int GetGameState() {
		return GAME_STATE;
	}
}
