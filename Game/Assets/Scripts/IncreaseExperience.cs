using UnityEngine;
using System.Collections;

public static class IncreaseExperience {

	private static int xpToGive;
	private static LevelUp levelUpScript = new LevelUp();

	public static void addExperience() {
		xpToGive = GameInformation.PlayerLevel * 100;
		GameInformation.CurrentXP += xpToGive;
		if (GameInformation.CurrentXP >= GameInformation.RequiredXP) {
			// then player leveled up
			levelUpScript.levelUpCharacter();
		}
		Debug.Log (xpToGive);
	}

}
