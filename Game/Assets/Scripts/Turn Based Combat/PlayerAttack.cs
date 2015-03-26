using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
    public float timeBetweenAttacks = .5f;
    public int attackDamage = 20;
    public float range = 5f;

    float timer;
    int shootableMask;
    Ray shootRay;
    RaycastHit shootHit;
    LineRenderer gunLine;
    AudioSource gunAudio;
    float effectsDisplayTime = .2f;

	// Use this for initialization
	void Awake () {
        shootableMask = LayerMask.GetMask("Shootable");
        gunLine = GetComponent<LineRenderer>();
        gunAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	    //Add time since last update was called to timer
        timer += Time.deltaTime;

        //If the attack button is being pressed and you can fire, do so
        if (Input.GetButton("Fire1") && timer >= timeBetweenAttacks)
        {
            Attack();
        }

        if (timer >= effectsDisplayTime * timeBetweenAttacks)
        {
            DisableEffects();
        }
    }

    public void DisableEffects()
    {
        gunLine.enabled = false;
    }

    void Attack()
    {
        //Reset the timer
        timer = 0f;
        gunLine.enabled = true;
        gunLine.SetPosition(0, transform.position);
        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;
        if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
        {
            SimpleEnemyHealth enemyHealth = shootHit.collider.GetComponent<SimpleEnemyHealth>();
            if (enemyHealth != null)
                enemyHealth.TakeDamage(attackDamage);
            gunLine.SetPosition(1, shootHit.point);
        }
        else
        {
            gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
        }
    }

}
