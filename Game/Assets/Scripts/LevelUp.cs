using UnityEngine;
using System.Collections;

public class LevelUp {
	private int maxPlayerLevel = 50;

	public void levelUpCharacter() {
		// check to see if current xp > required xp
		if (GameInformation.CurrentXP > GameInformation.RequiredXP) {
						GameInformation.CurrentXP -= GameInformation.RequiredXP;
		} else {
			GameInformation.CurrentXP = 0;
		}
		if (GameInformation.PlayerLevel < maxPlayerLevel) {
						GameInformation.PlayerLevel += 1;
		} else {
			GameInformation.PlayerLevel = maxPlayerLevel;
		}
		// give stat points
		// give move/ability
		// determine next amount of required experience
		GameInformation.RequiredXP = GameInformation.PlayerLevel * 1000 + 250;

	}

	private void determineRequiredXP() {
		GameInformation.RequiredXP = GameInformation.PlayerLevel * 1000 + 250;
	}
}
