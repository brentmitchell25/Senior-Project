using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
    public GUIControls GUIcontrols;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public bool[] spawnedEnemies;
    public int curEnemyCount;
    public int maxEnemyCount;
	// Use this for initialization
	void Start () {
        curEnemyCount = 0;
        maxEnemyCount = 2;
        if (maxEnemyCount > spawnPoints.Length)
        {
            maxEnemyCount = spawnPoints.Length;//prevents infinite spawning loop
        }
        spawnedEnemies = new bool[spawnPoints.Length];
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            spawnedEnemies[i] = false;
        }
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Spawn () {
	    //if player has no health left, or if there is already the max number of enemies out, don't spawn any more
        if (GUIcontrols.curHealth <= 0f || curEnemyCount >= maxEnemyCount)
        {
            print("did not spawn");
            return;
        }

        //Find a random index between zero and one less than the number of spawn points
        
        int spawnPointIndex = 0;
        do
        {
            spawnPointIndex = Random.Range(0, spawnPoints.Length);
            print("spawned at spawnpoint " + spawnPointIndex);
        } while (spawnedEnemies[spawnPointIndex]);

        curEnemyCount += 1; 
        //Create an instance of enemy prefab at the random spawn point
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        spawnedEnemies[spawnPointIndex] = true;
    }
}
