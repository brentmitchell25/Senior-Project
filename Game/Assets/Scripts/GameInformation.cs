using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
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

	public static string Endurance {
		get;
		set;
	}

	public static string Intellect {
		get;
		set;
	}

	public static string Strength {
		get;
		set;
	}
}
