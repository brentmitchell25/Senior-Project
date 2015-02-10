using UnityEngine;
using System.Collections;

public class SimpleEnemyMovement : MonoBehaviour {

    Transform player;
    GUIControls GUIcontrols;
    SimpleEnemyHealth enemyHealth;
    NavMeshAgent nav;
    int AggroRange = 10;
    bool Aggro = false;
    Vector3 StartPosition;
    int TravelRange = 30;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        GUIcontrols = player.GetComponent<GUIControls>();
        enemyHealth = GetComponent<SimpleEnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
        StartPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        //Check to see if player pulls aggro
        if (Vector3.Distance(transform.position, player.transform.position) < AggroRange)
        {
            Aggro = true;
        }

        //Check to see how far away enemy is from start position. If too far, move them back to their starting position. 
        if (Vector3.Distance(transform.position, StartPosition) > TravelRange)
        {
            Aggro = false;
            nav.SetDestination(StartPosition);
        }

        if (Aggro)
        {
            // If the enemy and the player have health left...
            if (enemyHealth.curHealth > 0 && GUIcontrols.curHealth > 0)
            {
                // ... set the destination of the nav mesh agent to the player.
                nav.SetDestination(player.position);
            }
            // Otherwise...
            else
            {
                // ... disable the nav mesh agent.
                nav.enabled = false;
            }
        }


	}
}
