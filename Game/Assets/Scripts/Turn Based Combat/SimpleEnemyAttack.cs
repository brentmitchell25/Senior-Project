using UnityEngine;
using System.Collections;

public class SimpleEnemyAttack : MonoBehaviour {
    public float timeBetweenAttacks = .5f;
    public int attackDamage = 10;
    public AudioClip Snarl;

    Animator anim;
    AudioSource audioSource;
    GameObject player;
    GUIControls GUIcontrols;
    SimpleEnemyHealth enemyHealth;
    SimpleEnemyMovement enemyMovement;
    int AttackCounter = 0;
    bool playerInRange;
    float timer;

	// Use this for initialization
	void Awake () {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.dopplerLevel = 0;
        audioSource.volume = .05f;
        Snarl = Resources.Load("Audio/Sound fx/Animals/Other/Gorilla Snarl #2") as AudioClip;
        player = GameObject.FindGameObjectWithTag("Player");
        GUIcontrols = player.GetComponent<GUIControls>();
        enemyHealth = GetComponent<SimpleEnemyHealth>();
        enemyMovement = GetComponent<SimpleEnemyMovement>();
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

		if (timer >= timeBetweenAttacks) {
			Debug.Log(playerInRange);
			Debug.Log(enemyHealth.curHealth > 0);
			Debug.Log(!enemyMovement.AggroReset);
				}
        //If timer exceeds time between attacks, you should attack player
        if (timer >= timeBetweenAttacks && playerInRange && enemyHealth.curHealth > 0 && !enemyMovement.AggroReset)
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
            AttackCounter += 1;
            print("Attacked, " + AttackCounter);
            GUIcontrols.TakeDamage(attackDamage);
            audioSource.clip = Snarl;
            audioSource.Play();
            //AudioSource.PlayClipAtPoint(Snarl, Vector3.zero);
        }

    }
}
