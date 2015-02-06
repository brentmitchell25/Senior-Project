using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIControls : MonoBehaviour
{
    CharacterMotor CharacterMotor;
    bool isDead;
    bool damaged;
    [HideInInspector]
    public bool exhausted;
    public int maxHealth = 100;
    public int curHealth = 100;
    public int maxMana = 100;
    public int curMana = 100; 
    public int maxStam = 100;
    public int curStam = 100;
    public int maxExp = 100;
    public int curExp = 0;
    public int level = 1;
    public int healthRegen = 1;
    public int manaRegen = 1;
    public int stamRegen = 1;
    [HideInInspector]
    public int regenCounter = 0;
    [HideInInspector]
    public int regenTick = 15;
    

    public Slider healthSlider;
    public Slider manaSlider;
    public Slider stamSlider;
    public Slider expSlider;

    public Image damageImage;
    public float damageScreenFlashSpeed = 5f;
    public Color damageScreenFlashColor = new Color(1f, 0f, 0f, .1f);

    Animator anim;
    AudioSource playerAudio;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        CharacterMotor = GetComponent<CharacterMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        //Flash damage splash screen
        if (damaged)
        {
            //damageImage.color = flashColor;
        }
        else
        {
            //damageImage.color = Color.Lerp(damageImage.color, Color.clear, damageScreenFlashSpeed * Time.deltaTime);
        }
        damaged = false;

        //level up if necessary
        if (curExp >= maxExp) {
            LevelUp();
        }

        //set exhausted if drop below 10 stam. Clear when above 10 stam. Prevents on-off sprinting
        if (curStam <= 0)
        {
            exhausted = true;
            curStam = 0;
        }
        if (curStam >= 10)
            exhausted = false;

        //regen
        regenerate();
        //update sliders
        healthSlider.value = curHealth * 100 / maxHealth;
        manaSlider.value = curMana * 100 / maxMana;
        stamSlider.value = curStam * 100 / maxStam;
        expSlider.value = curExp * 100 / maxExp;
    }

    public void TakeDamage(int amount)
    {
        damaged = true;
        curHealth -= amount;
        healthSlider.value = curHealth * 100 / maxHealth;
        //playerAudio.clip = damagedClip;
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

    void LevelUp()
    {
        curExp = 0;
        //playerAudio.clip = TakeDamageClip;
        playerAudio.Play();
        maxExp = (int) (maxExp * 1.12);
        maxHealth += 10;
        maxMana += 10;
        maxStam += 10;
        level++;
    }

    void regenerate()
    {
        if (regenCounter >= regenTick)
        {
            regenCounter = 0;
            if (curHealth < maxHealth)
            {
                curHealth += healthRegen;
            }
            if (curMana < maxMana)
            {
                curMana += manaRegen;
            }
            if (curStam < maxStam)
            {
                curStam += stamRegen;
            }
        }
        else
        {
            regenCounter += 1;
        }
    }

    void onGUI()
    {

    }
}
