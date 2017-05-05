using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour {

    public Slider healthBar;
    public Text HPText;

    public int maxHealth;
    public int currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        HPText.text = "HP: " + currentHealth + "/" + maxHealth;
    }
	
	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
        healthBar.value = currentHealth;
        HPText.text = "HP: " + currentHealth + "/" + maxHealth;
    }

    public void HurtPlayer(int damage)
    {
        currentHealth -= damage;
    }

    public void SetMaxHealth()
    {
        currentHealth = maxHealth;
    }
}
