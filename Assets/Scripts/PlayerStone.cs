using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStone : MonoBehaviour {

    DiceRoll theDiceRoller;
    
	// Use this for initialization
	void Start () {
        theDiceRoller = GameObject.FindObjectOfType<DiceRoll>();
	}

	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseUp()
    {
        int movableSpaces = theDiceRoller.diceTotal;
        //TODO: Is mouse over UI element? If so, ignore this click.

        //TODO: Is our turn?

        //TODO: Has dice been rolled?
        if (theDiceRoller.hasRolled == false)
        {
            Debug.Log("Please Roll a #.");
            return;
        }

        if (theDiceRoller.hasRolled)
        {
            //Move this stone
            Debug.Log("Meow!");
        }

    }
}
