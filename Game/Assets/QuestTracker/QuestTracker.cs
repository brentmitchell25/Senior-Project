using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestTracker : MonoBehaviour {
	private CanvasGroup questTracker;
	private Toggle quest1;
	private Toggle quest2;
	private Toggle quest3;
	// Use this for initialization
	void Start () {
		questTracker = GameObject.Find ("QuestContainer").GetComponent<CanvasGroup>() as CanvasGroup;
		quest1 = (Toggle)GameObject.Find ("Quest 1").GetComponent<Toggle>() as Toggle;
		quest2 = (Toggle)GameObject.Find ("Quest 2").GetComponent<Toggle>() as Toggle;
		quest3 = (Toggle)GameObject.Find ("Quest 3").GetComponent<Toggle>() as Toggle;

		quest2.isOn = true;
		setDisabled ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("tab") || Input.GetKeyDown ("l")) {
			setEnabled();
				}

		if(Input.GetKeyUp ("tab") || Input.GetKeyUp ("l")) {
			setDisabled();
		}
	}

	void setEnabled() {
		questTracker.alpha = 1;

		}

	void setDisabled() {
		questTracker.alpha = 0;
	}
}
