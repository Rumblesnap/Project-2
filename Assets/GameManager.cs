using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject gameManager = null;
	public int counter = 0;

	public bool isPlayer1Turn = true;
	public bool isPlayer2Turn = false;

	public bool a1Player1 = false;
	public bool a2Player1 = false;
	public bool a3Player1 = false;
	public bool b1Player1 = false;
	public bool b2Player1 = false;
	public bool b3Player1 = false;
	public bool c1Player1 = false;
	public bool c2Player1 = false;
	public bool c3Player1 = false;

	public bool a1Player2 = false;
	public bool a2Player2 = false;
	public bool a3Player2 = false;
	public bool b1Player2 = false;
	public bool b2Player2 = false;
	public bool b3Player2 = false;
	public bool c1Player2 = false;
	public bool c2Player2 = false;
	public bool c3Player2 = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (a1Player1 == true && a2Player1 == true && a3Player1 == true) {
			print ("Player 1 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (b1Player1 == true && b2Player1 == true && b3Player1 == true) {
			print ("Player 1 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (c1Player1 == true && c2Player1 == true && c3Player1 == true) {
			print ("Player 1 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (a1Player1 == true && b1Player1 == true && c1Player1 == true) {
			print ("Player 1 wins!");
			Invoke ("resetGame", 3.0f);
		}
		else if (a2Player1 == true && b2Player1 == true && c2Player1 == true) {
			print ("Player 1 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (a3Player1 == true && b3Player1 == true && c3Player1 == true) {
			print ("Player 1 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (a1Player1 == true && b2Player1 == true && c3Player1 == true) {
			print ("Player 1 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (c1Player1 == true && b2Player1 == true && a3Player1 == true) {
			print ("Player 1 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (a1Player2 == true && a2Player2 == true && a3Player2 == true) {
			print ("Player 2 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (b1Player2 == true && b2Player2 == true && b3Player2 == true) {
			print ("Player 2 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (c1Player2 == true && c2Player2 == true && c3Player2 == true) {
			print ("Player 2 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (a1Player2 == true && b1Player2 == true && c1Player2 == true) {
			print ("Player 2 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (a2Player2 == true && b2Player2 == true && c2Player2 == true) {
			print ("Player 2 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (a3Player2 == true && b3Player2 == true && c3Player2 == true) {
			print ("Player 2 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (a1Player2 == true && b2Player2 == true && c3Player2 == true) {
			print ("Player 2 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (c1Player2 == true && b2Player2 == true && a3Player2 == true) {
			print ("Player 2 wins!");
			Invoke ("resetGame", 1.0f);
		}
		else if (counter == 9) {
			print ("Draw!");
			Invoke ("resetGame", 1.0f);
		}
		
	}

	public void resetGame() {
		counter = 0;

		isPlayer1Turn = true;
		isPlayer2Turn = false;

		a1Player1 = false;
		a2Player1 = false;
		a3Player1 = false;
		b1Player1 = false;
		b2Player1 = false;
		b3Player1 = false;
		c1Player1 = false;
		c2Player1 = false;
		c3Player1 = false;

		a1Player2 = false;
		a2Player2 = false;
		a3Player2 = false;
		b1Player2 = false;
		b2Player2 = false;
		b3Player2 = false;
		c1Player2 = false;
		c2Player2 = false;
		c3Player2 = false;

		var A1 = GameObject.Find("A1");
		var A2 = GameObject.Find("A2");
		var A3 = GameObject.Find("A3");
		var B1 = GameObject.Find("B1");
		var B2 = GameObject.Find("B2");
		var B3 = GameObject.Find("B3");
		var C1 = GameObject.Find("C1");
		var C2 = GameObject.Find("C2");
		var C3 = GameObject.Find("C3");

		A1.GetComponent<Renderer> ().material.color = Color.white;
		A2.GetComponent<Renderer> ().material.color = Color.white;
		A3.GetComponent<Renderer> ().material.color = Color.white;
		B1.GetComponent<Renderer> ().material.color = Color.white;
		B2.GetComponent<Renderer> ().material.color = Color.white;
		B3.GetComponent<Renderer> ().material.color = Color.white;
		C1.GetComponent<Renderer> ().material.color = Color.white;
		C2.GetComponent<Renderer> ().material.color = Color.white;
		C3.GetComponent<Renderer> ().material.color = Color.white;
	
	}
		
	public void TurnWasTaken () {
		if (isPlayer1Turn == true) {
			isPlayer1Turn = false;
			isPlayer2Turn = true;
		} else if (isPlayer1Turn == false) {
			isPlayer1Turn = true;
			isPlayer2Turn = false;
		}

	}

}
