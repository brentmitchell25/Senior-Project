using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
    public GUIControls GUIcontrols;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Spawn () {
	    //if player has no health left, don't spawn any more
        if (GUIcontrols.curHealth <= 0f)
        {
            return;
        }

        //Find a random index between zero and one less than the number of spawn points
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        //Create an instance of enemy prefab at the random spawn point
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
