using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	string state1 = "You're alone in a prison cell, and you want to escape, There are " +
	                "some dirty sheets on the bed, a mirror on the wall, and the door " +
	                "is locked from the outside.\n\n" +
					"Press S to view Sheets, M to view Mirror, or L to view Lock";
	

	private void _setText(string str) {
		text.text = str;
	}

	// Use this for initialization
	void Start () {
		_setText("Press Space Key to Begin!");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			_setText (state1);
		}
	}
}
