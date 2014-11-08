using UnityEngine;
using System.Collections;

public class BasePlayer {

	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;

	private int stamina;		// health modifier
	private int endurance;		// energy modifier
	private int intellect;		// magical damage modifier
	private int strength;		// physical damamge modifier
	private int agility;		// haste and crit modifier
	private int resistance;		// all damager reduction

	private int currentXP;
	private int requiredXP;

	private int gold;			// currency

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

	public int Stamina {
		get {
			return stamina;
		}
		set {
			stamina = value;
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

	public int Agility {
		get {
			return agility;
		}
		set {
			agility = value;
		}
	}

	public int Resistance {
		get {
			return resistance;
		}
		set {
			resistance = value;
		}
	}

	public int CurrentXP {
		get {
			return currentXP;
		}
		set {
			currentXP = value;
		}
	}

	public int RequiredXP {
		get {
			return requiredXP;
		}
		set {
			requiredXP = value;
		}
	}

	public int Gold {
		get {
			return gold;
		}
		set {
			gold = value;
		}
	}
}
