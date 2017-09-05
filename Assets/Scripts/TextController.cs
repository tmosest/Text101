using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;

	private void _setText(string str) {
		text.text = str;
	}

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		switch (myState) {
			case States.cell:
				_state_cell ();
				break;
			case States.mirror:
				_state_mirror ();
				break;
			case States.sheets_0:
				_state_sheets_0 ();
				break;
			case States.lock_0:
				_state_lock0 ();
				break;
			case States.cell_mirror:
				_state_cell_mirror ();
				break;
			case States.lock_1:
				_state_lock1 ();
				break;
			case States.sheets_1:
				_state_sheets_1 ();
				break;
			case States.freedom:
				_state_freedom ();
				break;
		}
	}

	private void _state_cell() {
		string stateText = "You're alone in a prison cell, and you want to escape.\n\n There are " +
			"some dirty sheets on the bed, a mirror on the wall, and the door " +
			"is locked from the outside.\n\n" +
			"Press S to view Sheets, M to view Mirror, or L to view Lock";
		_setText (stateText);

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		}
	}

	private void _state_mirror() {
		string stateText = "You seem to have found a broken mirror.\n\n" +
		                   "It is probably useless so you can return with R or take it with T.";
		_setText (stateText);

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell_mirror;
		}
	}

	private void _state_sheets_0() {
		string stateText = "I can't believe you have to sleep in these things.\n\n" +
		                   "Atleast there are rats to keep you company.\n\n" + 
							"Press R to return to your cell.";
		_setText (stateText);

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	private void _state_lock0() {
		string stateText = "It appears to be an old rust lock.\n\n" +
		                   "Maybe there is something else in the cell that can help you.\n\n" +
		                   "Press R to return to you cell.";
		_setText (stateText);

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	private void _state_cell_mirror() {
		string stateText = "You took the stupid mirror now what!.\n\n" +
			"Press S to view the Sheets or press L to look at the lock.";
		_setText (stateText);

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		} 
	}

	private void _state_sheets_1() {
		string stateText = "I can't believe you have to sleep in these things.\n\n" +
			"They look even worse throught the mirror...\n\n" + 
			"Press R to return to your cell.";
		_setText (stateText);

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}

	private void _state_lock1() {
		string stateText = "It appears to be an old rust lock.\n\n" +
			"Use O to try to open your cell or.\n\n" +
			"Press R to return to you cell.";
		_setText (stateText);

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.freedom;
		}
	}

	private void _state_freedom() {
		string stateText = "You opened the door and won!!!\n\n" +
		                   "Press P to play agagin!";		
		_setText (stateText);
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
		}
	}

}
