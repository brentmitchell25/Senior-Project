using UnityEngine;
using System.Collections;

public class setHideOutFlag : MonoBehaviour {
    GameObject player;
    CanvasGroup questTracker;
    QuestTracker QT;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        questTracker = GameObject.Find("QuestContainer").GetComponent<CanvasGroup>() as CanvasGroup;
        QT = GameObject.Find("QuestTracker").GetComponent<QuestTracker>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        //If the entering collider is the player
        if (other.gameObject == player)
        {
            //Found the hideout
            QT.enteredArea("hideout");
            print("entered hideout");
        }
    }
}
