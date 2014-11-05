using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour
{

		private BaseWeapon newWeapon;

	void Start() {
		createWeapon ();
		Debug.Log (newWeapon.ItemName);
		Debug.Log (newWeapon.ItemDescription);
		Debug.Log (newWeapon.ItemID.ToString());
		Debug.Log (newWeapon.WeaponType.ToString());
		Debug.Log (newWeapon.Stamina.ToString());
		Debug.Log (newWeapon.Endurance.ToString());
		}
		public void createWeapon ()
		{

				newWeapon = new BaseWeapon ();
				// assign name to weapon
				newWeapon.ItemName = "W" + Random.Range (1, 101);
				// create a weapon description
				newWeapon.ItemDescription = "This is a new weapon.";
				// weapon id
				newWeapon.ItemID = Random.Range (1, 101);
				// stats
				newWeapon.Stamina = Random.Range (1, 11);
				newWeapon.Endurance = Random.Range (1, 11);
				newWeapon.Intellect = Random.Range (1, 11);
				newWeapon.Strength = Random.Range (1, 11);
				// choose weapon type

		}

		private void chooseWeaponType ()
		{
			int randomTemp = Random.Range (1, 7);
			if (randomTemp == 1) {
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
			} else if (randomTemp == 2) {
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
			} else if (randomTemp == 3) {
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
			} else if (randomTemp == 4) {
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
			} else if (randomTemp == 5) {
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
			} else {
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
			}
		}
}
