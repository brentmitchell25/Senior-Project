using UnityEngine;
using System.Collections;

public class SetWeapon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (GameInformation.PlayerClass != null) {

						if (GameInformation.PlayerClass.ToString ().Equals ("BaseWarriorClass")) {
								GameObject.Find ("Sword").SetActive (true);
								GameObject.Find ("Bow").SetActive (false);
						} else if (GameInformation.PlayerClass.ToString ().Equals ("BaseRangedClass")) {
								GameObject.Find ("Bow").SetActive (true);
								GameObject.Find ("Sword").SetActive (false);
						
						} else if (GameInformation.PlayerClass.ToString ().Equals ("BaseMageClass")) {
								GameObject.Find ("Bow").SetActive (false);
								GameObject.Find ("Sword").SetActive (false);
						} else {
								GameObject.Find ("Bow").SetActive (false);
								GameObject.Find ("Sword").SetActive (false);
						}
				} else {
						GameObject.Find ("Bow").SetActive (false);
						GameObject.Find ("Sword").SetActive (false);
				}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
