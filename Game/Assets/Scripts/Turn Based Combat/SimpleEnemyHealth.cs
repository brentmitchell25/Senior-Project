using UnityEngine;
using System.Collections;

public class SimpleEnemyHealth : MonoBehaviour {
    public int curHealth = 100;
    public int maxHealth = 100;
    public int exp = 110;
    public float sinkSpeed = 2.5f;
    public AudioClip deathClip;

    Animator anim;
    AudioSource enemyAudio;
    SphereCollider sphereCollider;
    GUIControls GUIcontrols;
    bool isDead;
    bool isSinking;

	// Use this for initialization
	void Awake () {
        anim = GetComponent<Animator>();
        enemyAudio = GetComponent<AudioSource>();
        sphereCollider = GetComponent<SphereCollider>();
        GUIcontrols = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<GUIControls>();
    }
	
	// Update is called once per frame
	void Update () {
	    //if enemy should be sinking, move enemy down by SinkSpeed per second
        if (isSinking)
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
	}

    public void TakeDamage(int amount)
    {
        if (isDead)
            return;
        enemyAudio.Play();
        curHealth -= amount;
        if (curHealth <= 0) 
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
        sphereCollider.isTrigger = true; //allows shots to pass through it
        //anim.SetTrigger("Dead");
        enemyAudio.clip = deathClip;
        enemyAudio.Play();
        GUIcontrols.curExp += exp;
        StartSinking();
    }

    public void StartSinking()
    {
        GetComponent<NavMeshAgent>().enabled = false;//take it off the navmesh
        GetComponent<Rigidbody>().isKinematic = true;//make it kinematic since we're moving it
        isSinking = true;//start sinking
        Destroy(gameObject, 2f);//destroy it after 2 seconds
    }

    public bool getIsDead()
    {
        return isDead;
    }
}
