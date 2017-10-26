using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour {

	public GameObject gameManager = null;
	public bool isAvailable = true;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown() {
	
		if (gameManager.GetComponent<GameManager> ().isPlayer1Turn == true && gameObject.GetComponent<Renderer> ().material.color == Color.white) {
			gameObject.GetComponent<Renderer> ().material.color = Color.blue;
			if (gameObject.name == "A1") {
				gameManager.GetComponent<GameManager> ().a1Player1 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "A2") {
				gameManager.GetComponent<GameManager> ().a2Player1 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "A3") {
				gameManager.GetComponent<GameManager> ().a3Player1 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "B1") {
				gameManager.GetComponent<GameManager> ().b1Player1 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "B2") {
				gameManager.GetComponent<GameManager> ().b2Player1 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "B3") {
				gameManager.GetComponent<GameManager> ().b3Player1 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "C1") {
				gameManager.GetComponent<GameManager> ().c1Player1 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "C2") {
				gameManager.GetComponent<GameManager> ().c2Player1 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "C3") {
				gameManager.GetComponent<GameManager> ().c3Player1 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
		}
		else if (gameManager.GetComponent<GameManager> ().isPlayer2Turn == true && gameObject.GetComponent<Renderer> ().material.color == Color.white) {
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
			if (gameObject.name == "A1") {
				gameManager.GetComponent<GameManager> ().a1Player2 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "A2") {
				gameManager.GetComponent<GameManager> ().a2Player2 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "A3") {
				gameManager.GetComponent<GameManager> ().a3Player2 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "B1") {
				gameManager.GetComponent<GameManager> ().b1Player2 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;;
			}
			if (gameObject.name == "B2") {
				gameManager.GetComponent<GameManager> ().b2Player2 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "B3") {
				gameManager.GetComponent<GameManager> ().b3Player2 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "C1") {
				gameManager.GetComponent<GameManager> ().c1Player2 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "C2") {
				gameManager.GetComponent<GameManager> ().c2Player2 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
			if (gameObject.name == "C3") {
				gameManager.GetComponent<GameManager> ().c3Player2 = true;
				gameManager.GetComponent<GameManager> ().counter = gameManager.GetComponent<GameManager> ().counter + 1;
			}
		}
		isAvailable = false;
		gameManager.GetComponent<GameManager> ().TurnWasTaken ();
	}
}
