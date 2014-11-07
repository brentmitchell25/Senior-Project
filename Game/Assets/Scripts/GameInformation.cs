using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (gameObject);
	}

	public static BaseEquipment EquipmentOne {
		get;
		set;
	}

	public static string PlayerName {
		get;
		set;
	}

	public static int PlayerLevel {
		get;
		set;
	}

	public static BaseCharacterClass PlayerClass {
		get;
		set;
	}

	public static int Staminia {
		get;
		set;
	}

	public static int Endurance {
		get;
		set;
	}

	public static int Intellect {
		get;
		set;
	}

	public static int Strength {
		get;
		set;
	}
}
