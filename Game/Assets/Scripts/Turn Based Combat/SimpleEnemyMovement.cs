﻿using UnityEngine;
using System.Collections;

public class SimpleEnemyMovement : MonoBehaviour {

    Transform player;
    GUIControls GUIcontrols;
    //EnemyHealth enemyHealth;
    NavMeshAgent nav;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        GUIcontrols = player.GetComponent<GUIControls>();
        //enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        //// If the enemy and the player have health left...
        //if(enemyHealth.currentHealth > 0 && GUIcontrols.curHealth > 0)
        //{
        //    // ... set the destination of the nav mesh agent to the player.
            nav.SetDestination (player.position);
        //}
        //// Otherwise...
        //else
        //{
        //    // ... disable the nav mesh agent.
        //    nav.enabled = false;
        //}
	}
}
