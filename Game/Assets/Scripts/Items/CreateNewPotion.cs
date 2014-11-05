using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion;

	// Use this for initialization
	void Start () {
		createPotion ();

		Debug.Log (newPotion.ItemName);
		Debug.Log (newPotion.ItemDescription);
		Debug.Log (newPotion.ItemID.ToString());
		Debug.Log (newPotion.PotionType.ToString());

	}

	private void createPotion() {
		newPotion = new BasePotion ();
		newPotion.ItemName = "Potion";
		newPotion.ItemDescription = "This is a potion";
		newPotion.ItemID = Random.Range (1, 101);
		choosePotionType ();
	}

	private void choosePotionType() {
		int randomTemp = Random.Range (0, 7);
		if (randomTemp == 0) {
			newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
		} else if (randomTemp == 1) {
			newPotion.PotionType = BasePotion.PotionTypes.ENERGY;
		} else if (randomTemp == 2) {
			newPotion.PotionType = BasePotion.PotionTypes.ENDURANCE;
		} else if (randomTemp == 3) {
			newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
		} else if (randomTemp == 4) {
			newPotion.PotionType = BasePotion.PotionTypes.SPEED;
		} else if (randomTemp == 5) {
			newPotion.PotionType = BasePotion.PotionTypes.INTELLECT;
		} else {
			newPotion.PotionType = BasePotion.PotionTypes.VITALITY;
		}
	}
}
