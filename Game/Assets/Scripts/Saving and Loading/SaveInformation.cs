﻿using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation() {
		PlayerPrefs.SetInt ("PLAYERLEVEL",GameInformation.PlayerLevel);
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt ("STAMINIA",GameInformation.Strength);
		PlayerPrefs.SetInt ("ENDURANCE",GameInformation.Endurance);
		PlayerPrefs.SetInt ("INTELLECT",GameInformation.Intellect);
		PlayerPrefs.SetInt ("STRENGTH",GameInformation.Strength);
		PlayerPrefs.SetInt ("AGILITY",GameInformation.Agility);
		PlayerPrefs.SetInt ("RESISTANCE",GameInformation.Resistance);
		PlayerPrefs.SetInt ("GOLD",GameInformation.Gold);
		if (GameInformation.EquipmentOne != null) {
			PPSerialization.save ("EQUIPMENTITEM1", GameInformation.EquipmentOne);
		}
		Debug.Log ("Saved Information");
	}
}
