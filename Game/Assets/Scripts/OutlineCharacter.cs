using UnityEngine;
using System.Collections;

public class OutlineCharacter : MonoBehaviour {
	private GameObject player;

	void Start() {
		Debug.Log ("Start");
		}

	void Update()
	{
		if (gameObject.name.Equals("ArcherBowHighlighted")) {
			Debug.Log (gameObject.ToString ());
						if (renderer.IsVisibleFrom (GameObject.Find ("RightEyeAnchor").camera)) {
								Debug.Log ("Visible");
								gameObject.SetActive (true);
						} else {
								Debug.Log ("Not visible");
								gameObject.SetActive (false);
						}
				}

	}
}
