using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
    public float timeBetweenAttacks = .5f;
    public int attackDamage = 20;
    public float range = 5f;

    float timer;
    int shootableMask;

	// Use this for initialization
	void Awake () {
        shootableMask = LayerMask.GetMask("Shootable");
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
    }
        void Attack()
        {
            //Reset the timer
            timer = 0f;
            print("Attacked");
            ////TODO: Finish this

        }

}
