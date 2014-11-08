using UnityEngine;
using System.Collections;

public class CreatePlayerGUI : MonoBehaviour {

	public enum CreatePlayerStates {
		CLASS, // display all class types
		STATALLOCATION,	// allocate stats where player want too
		FINALSETUP //add name and misc items
	}
	
	private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions ();
	private CreatePlayerStates currentState;
	
	// Use this for initialization
	void Start () {
		currentState = CreatePlayerStates.CLASS;
	}
	
	// Update is called once per frame
	void Update () {
		switch (currentState) {
		case(CreatePlayerStates.CLASS):
			break;
		case(CreatePlayerStates.STATALLOCATION):
			break;
		case(CreatePlayerStates.FINALSETUP):
			break;
		}
	}
	
	void OnGUI() {
		displayFunctions.displayMainItems ();
		if (CreatePlayerStates.CLASS == currentState) {
			// Display class selction function
			displayFunctions.displayClassSelections();
		}
		if (CreatePlayerStates.STATALLOCATION == currentState) {
			// Display class selction function
			displayFunctions.displayStatAllocation();
		}
		if (CreatePlayerStates.FINALSETUP == currentState) {
			// Display class selction function
			displayFunctions.displayFinalSetup ();
		}
	}
}
