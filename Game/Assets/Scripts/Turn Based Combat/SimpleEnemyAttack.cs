using UnityEngine;
using System.Collections;

public class SimpleEnemyAttack : MonoBehaviour {
    public float timeBetweenAttacks = .5f;
    public int attackDamage = 10;
    public AudioClip LevelUpClip;

    Animator anim;
    GameObject player;
    GUIControls GUIcontrols;
    SimpleEnemyHealth enemyHealth;
    bool playerInRange;
    float timer;

	// Use this for initialization
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player");
        GUIcontrols = player.GetComponent<GUIControls>();
        enemyHealth = GetComponent<SimpleEnemyHealth>();
        anim = GetComponent<Animator>();

	}

    void OnTriggerEnter(Collider other)
    {
        //If the entering collider is the player
        if (other.gameObject == player)
        {
            //The player is in attack range.
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //If the exiting collider is the player
        if (other.gameObject == player)
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        //Add time since Update was last called to timer
        timer += Time.deltaTime;

        //If timer exceeds time between attacks, you should attack player
        if (timer >= timeBetweenAttacks && playerInRange && enemyHealth.curHealth > 0)
            Attack();

    }

    void Attack()
    {
        //Reset timer
        timer = 0f;

        //If player has health to lose
        if (GUIcontrols.curHealth > 0)
        {
            //then damage the player
            GUIcontrols.TakeDamage(attackDamage);
            AudioSource.PlayClipAtPoint(LevelUpClip, Vector3.zero);
        }

    }
}
