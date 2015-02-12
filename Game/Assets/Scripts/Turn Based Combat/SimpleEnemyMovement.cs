using UnityEngine;
using System.Collections;

public class SimpleEnemyMovement : MonoBehaviour {

    Transform player;
    GUIControls GUIcontrols;
    SimpleEnemyHealth enemyHealth;
    NavMeshAgent nav;
    int AggroRange = 10;
    bool Aggro = false;
    public bool AggroReset = false;
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

        //Check to see how far away enemy is from start position. If too far, move them back to their starting position. AggroReset ensures they go all the way back.
        if (Vector3.Distance(transform.position, StartPosition) > TravelRange)
        {
            Aggro = false;
            AggroReset = true;
            nav.SetDestination(StartPosition);
        }
        //If AggroReset is true, make sure to turn it off whenever they reach their StartPosition
        if (Vector3.Distance(transform.position,StartPosition) < 1 && AggroReset)
            AggroReset = false;

        if (Aggro && !AggroReset)
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
