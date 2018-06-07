using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int[] diceVals = new int[4];
	public int diceTotal;

    public bool isRolling = false;
    public bool hasRolled;

    public void NewTurn()
    {
        //Start of players turn
        //We don't have a roll for them yet.
        hasRolled = false;
}

    public void RollTheDice(){
		diceTotal = 0;

		//Quill's way...
		for (int i = 0; i < diceVals.Length; i++) {
			diceVals [i] = Random.Range (0, 2);
			diceTotal += diceVals [i];
		}

        //if we had an animation for rolling dice, we would play it here.
		hasRolled = true;
        

        //My way...
    }
}
