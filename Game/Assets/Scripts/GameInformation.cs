﻿using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (gameObject);
	}

	public static bool IsMale {
		get;
		set;
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

	public static int Stamina {
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

	public static int Agility {
		get;
		set;
	}

	public static int Resistance {
		get;
		set;
	}

	public static int Gold {
		get;
		set;
	}

	public static int CurrentXP {
		get;
		set;
	}

	public static int RequiredXP {
		get;
		set;
	}

	public static float ArcherAngle {
				get;
				set;
		}

	public static float MeleeAngle {
				get;
				set;
		}

	public static float MageAngle {
				get;
				set;
		}
}
