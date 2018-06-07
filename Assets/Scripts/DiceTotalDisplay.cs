using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceTotalDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        theDiceRoll = GameObject.FindObjectOfType<DiceRoll>();
	}

    DiceRoll theDiceRoll;

	// Update is called once per frame
	void Update () {
        if(theDiceRoll.isRolling == true)
        {
            GetComponent<Text>().text = "= ?";
        }
        else
        {
            GetComponent<Text>().text = "= " + theDiceRoll.diceTotal;
        }

    }
}
