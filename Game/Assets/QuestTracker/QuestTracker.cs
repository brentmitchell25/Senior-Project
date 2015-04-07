﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestTracker : MonoBehaviour {
	private CanvasGroup questTracker;
	private Toggle quest1;
	private Toggle quest2;
	private Toggle quest3;
    GUIControls GUIcontrols;
    Transform player;
    Text winText;

    private int gorillaKillCount = 0;
    private bool foundHideout = false;
	// Use this for initialization
	void Start () {
		questTracker = GameObject.Find ("QuestContainer").GetComponent<CanvasGroup>() as CanvasGroup;
		quest1 = (Toggle)GameObject.Find ("Quest 1").GetComponent<Toggle>() as Toggle;
		quest2 = (Toggle)GameObject.Find ("Quest 2").GetComponent<Toggle>() as Toggle;
		quest3 = (Toggle)GameObject.Find ("Quest 3").GetComponent<Toggle>() as Toggle;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        GUIcontrols = player.GetComponent<GUIControls>();
        winText = player.GetComponentInChildren<Text>();
        winText.enabled = false;
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

    public void creatureKilled(string creatureName)
    {
        if (creatureName == "gorilla")
        {
            gorillaKillCount++;
            print("gorillaKillCount = " + gorillaKillCount);
            updateQuests();
        }
    }

    public void enteredArea(string areaName)
    {
        if (areaName == "hideout")
            foundHideout = true;
    }

    public void updateQuests()
    {
        if (gorillaKillCount >= 5)
        {
            quest1.isOn = true;
        }

        if (foundHideout == true)
        {
            quest2.isOn = true;
        }

        if (GUIcontrols.level >= 3)
        {
            quest3.isOn = true;
        }

        checkGameComplete();
    }

    void checkGameComplete()
    {
        if (quest1.isOn == true && quest2.isOn == true && quest3.isOn == true)
        {
            //player wins
            winText.enabled = true;
        }
    }
}