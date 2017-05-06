using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour {

    public Slider healthBar;
    public Text HPText;

    public static int maxHealth = 100;
    public static int currentHealth = 100;

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
        Debug.Log("Hero fully recovered");
        currentHealth = maxHealth;
    }

	public static void setHealth(int current, int max)
	{
		currentHealth = current;
		maxHealth = max;
	}
		
}
