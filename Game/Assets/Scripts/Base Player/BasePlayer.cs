using UnityEngine;
using System.Collections;

public class BasePlayer {

	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;
	private int staminia;
	private int endurance;
	private int intellect;
	private int strength;

	public string PlayerName {
		get {
			return playerName;
		}
		set {
			playerName = value;
		}
	}

	public int PlayerLevel {
		get {
			return playerLevel;
		}
		set {
			playerLevel = value;
		}
	}

	public BaseCharacterClass PlayerClass {
		get {
			return playerClass;
		}
		set {
			playerClass = value;
		}
	}

	public int Staminia {
		get {
			return staminia;
		}
		set {
			staminia = value;
		}
	}

	public int Endurance {
		get {
			return endurance;
		}
		set {
			endurance = value;
		}
	}

	public int Intellect {
		get {
			return intellect;
		}
		set {
			intellect = value;
		}
	}

	public int Strength {
		get {
			return strength;
		}
		set {
			strength = value;
		}
	}
}
