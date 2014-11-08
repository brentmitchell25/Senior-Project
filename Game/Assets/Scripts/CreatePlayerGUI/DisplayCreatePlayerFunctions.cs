using UnityEngine;
using System.Collections;

public class DisplayCreatePlayerFunctions {

	private int classSelection;
	private string[] classSelectionNames = new string[3] {"Mage", "Ranged", "Warrior"};
	public void displayClassSelections() {
		// List of toggle buttons and each button will be a different class
		// Selection grid
		classSelection = GUI.SelectionGrid (new Rect (50,50,250,300), classSelection, classSelectionNames, 3);
		GUI.Label (new Rect (450, 50, 300, 300), findClassDescription (classSelection));
		GUI.Label (new Rect (450, 100, 300, 300), findClassStatValues (classSelection));

	}
	
	public void displayStatAllocation() {
		// List of stats with plus and minus buttons to add stats
		// Make sure cannot add more than stats given
	}

	public void displayFinalSetup() {
		// name
		// gender
		// add description to character
	}

	public void displayMainItems() {
		Transform player = GameObject.FindGameObjectWithTag ("Player").transform;
		GUI.Label(new Rect(Screen.width/2,20,250,250),"CREATE NEW PLAYER");

		if(GUI.Button (new Rect(500,300,50,50),"<<<")) {
			// turn transform tagged as player to left
			player.Rotate (Vector3.up * 10);
		}
		if (GUI.Button (new Rect (650, 300, 50, 50), ">>>")) {
			// turn transform tagged as player to right
			player.Rotate (Vector3.down * 10);
		}
	}

	private string findClassDescription(int classSelection) {
		BaseCharacterClass tempClass;
		if (classSelection == 0) {
			tempClass = new BaseMageClass ();
		} else if (classSelection == 1) {
			tempClass = new BaseRangedClass ();
		} else {
			tempClass = new BaseWarriorClass();
		}
		return tempClass.CharacterClassDescription;

	}

	private string findClassStatValues(int classSelection) {
		BaseCharacterClass tempClass;
		if (classSelection == 0) {
			tempClass = new BaseMageClass ();
		} else if (classSelection == 1) {
			tempClass = new BaseRangedClass ();
		} else {
			tempClass = new BaseWarriorClass();
		}
		return "Stamina " + tempClass.Stamina + "\n" + "Endurance " + tempClass.Endurance;
	}
}
