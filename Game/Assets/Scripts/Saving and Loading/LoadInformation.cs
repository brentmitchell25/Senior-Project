using UnityEngine;
using System.Collections;

public class LoadInformation : MonoBehaviour {

	public static void LoadAllInformation() {
		GameInformation.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInformation.Staminia = PlayerPrefs.GetInt ("STAMINIA");
		GameInformation.Endurance = PlayerPrefs.GetInt ("ENDURANCE");
		GameInformation.Intellect = PlayerPrefs.GetInt ("INTELLECT");
		GameInformation.Strength = PlayerPrefs.GetInt ("STRENGTH");

		if (PlayerPrefs.GetString ("EQUIPMENT1") != null) {
			GameInformation.EquipmentOne = (BaseEquipment)PPSerialization.load ("EQUIPMENT1");
		}
	}
}
