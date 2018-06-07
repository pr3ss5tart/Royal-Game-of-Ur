using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour {

	public bool hasRolled;

	// Use this for initialization
	void Start () {
		hasRolled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int[] diceVals = new int[4];
	public int diceTotal;

	public void RollTheDice(){
		diceTotal = 0;

		//Quill's way...
		for (int i = 0; i < diceVals.Length; i++) {
			diceVals [i] = Random.Range (0, 2);
			diceTotal += diceVals [i];
		}
		Debug.Log ("Rolled: " + diceVals + " (" + diceTotal + ")");
		hasRolled = true;
		//My way...
	}
}
