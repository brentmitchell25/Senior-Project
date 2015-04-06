using UnityEngine;
using System.Collections;

public class DisplayCreatePlayerFunctions {

	private int classSelection;
	private string[] classSelectionNames = new string[3] {"Mage", "Ranged", "Warrior"};
	private string playerName = "Enter Player Name: ";
	private string playerBio;
	private string[] genderTypes= new string[2] {"Male","Female"};
	private int genderSelection;


	StatAllocationModule sam = new StatAllocationModule ();
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

		sam.DisplayStatAllocationModule ();
	}

	public void displayFinalSetup() {
		// name
		playerName = GUI.TextArea (new Rect (20, 10, 150, 25), playerName, 25);
		// gender
		genderSelection = GUI.SelectionGrid (new Rect (10, 50, 100, 70), genderSelection, genderTypes,1);
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
		// If not in final setup screen, then show next button
		if(CreatePlayerGUI.currentState != CreatePlayerGUI.CreatePlayerStates.FINALSETUP) {
			if(GUI.Button(new Rect(470,370,50,50),"Next")) {
				if(CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.CLASS) {
					chooseClass(classSelection);
					CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.STATALLOCATION;
				} else if(CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.STATALLOCATION){
					GameInformation.Stamina = StatAllocationModule.pointsToAllocate[0];
					GameInformation.Endurance = StatAllocationModule.pointsToAllocate[1];
					GameInformation.Intellect = StatAllocationModule.pointsToAllocate[2];
					GameInformation.Strength = StatAllocationModule.pointsToAllocate[3];
					GameInformation.Agility = StatAllocationModule.pointsToAllocate[4];
					GameInformation.Resistance = StatAllocationModule.pointsToAllocate[5];
					CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.FINALSETUP;
				}
			}
		} else {
			if(GUI.Button(new Rect(470,370,50,50),"Finish")) {
				// Final Save
				GameInformation.PlayerName = playerName;
				if(genderSelection == 0) {
					GameInformation.IsMale = true;
				} else {
					GameInformation.IsMale = false;
				}
				SaveInformation.SaveAllInformation();
			}
		}
		if(CreatePlayerGUI.currentState != CreatePlayerGUI.CreatePlayerStates.CLASS) {
			if(GUI.Button(new Rect(295,370,50,50),"Back")) {
				if(CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.STATALLOCATION) {
					StatAllocationModule.hasRunOnce = false;
					GameInformation.PlayerClass = null;
					CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.CLASS;
				} else if(CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.FINALSETUP){
					CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.STATALLOCATION;
				}
			}
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

	private void chooseClass(int classSelection) {
		if (classSelection == 0) {
			GameInformation.PlayerClass = new BaseMageClass();
		} else if (classSelection == 1) {
			GameInformation.PlayerClass = new BaseRangedClass();
		} else {
			GameInformation.PlayerClass = new BaseWarriorClass();
		}
	}

}
