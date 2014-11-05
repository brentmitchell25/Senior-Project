using UnityEngine;
using System.Collections;

public class TestGui : MonoBehaviour {
	private BaseCharacterClass mage = new BaseMageClass();
	private BaseCharacterClass warrior = new BaseWarriorClass();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
				GUILayout.Label (mage.CharacterClassName);
				GUILayout.Label (mage.CharacterClassDescription);
				GUILayout.Label (warrior.CharacterClassName);
				GUILayout.Label (warrior.CharacterClassDescription);
		}
}
