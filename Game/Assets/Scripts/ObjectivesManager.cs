using UnityEngine;
using System.Collections;

public class ObjectivesManager : MonoBehaviour {
    bool questLogOpened = false;
    Canvas HUDcanvas;
	// Use this for initialization
	void Start () {
        HUDcanvas = FindObjectOfType<Canvas>();
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            questLogOpened = !questLogOpened;
            print("questLogOpened = " + questLogOpened);
        }
    }

    void OnGUI()
    {
        if (questLogOpened)
        {
            
            GUI.Box(new Rect(100, 100, Screen.height, Screen.width), "Test");
        }
    }
}
