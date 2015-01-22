using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
    public int maxHealth = 100;
    public int curHealth = 100;
    //public Image damageImage;
    public Slider healthSlider;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1f, 0f, 0f, .1f);

    //Animator anim;
    //AudioSource playerAudio;
    CharacterMotor CharacterMotor;
    bool isDead;
    bool damaged;

	// Use this for initialization
	void Start () {
        //anim = GetComponent<Animator>();
        //playerAudio = GetComponent<AudioSource>();
        CharacterMotor = GetComponent<CharacterMotor>();
	}
	
	// Update is called once per frame
	void Update () {
        if (damaged)
        {
            //damageImage.color = flashColor;
        }
        else
        {
            //damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
        healthSlider.value = curHealth;
	}

    public void TakeDamage(int amount)
    {
        damaged = true;
        curHealth -= amount;
        healthSlider.value = curHealth;
        //playerAudio.Play();
        if (curHealth <= 0 && !isDead)
        {
            Death();
        }

    }

    void Death()
    {
        isDead = true;
        //anim.SetTrigger("Die");
        //playerAudio.clip = deathClip;
        //playerAudio.Play();
        CharacterMotor.canControl = false;

    }

    void onPointerDown()
    {
        curHealth -= 10;
        healthSlider.value = curHealth;
    }

    void onGUI()
    {

    }
}
