using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {

	private int level;
	private int exp;
	private int maxExp;
	private int gold;
	private int health;
	private int maxHealth;


	// Use this for initialization
	void Start () {
		level = LevelManager.currentLevel;
		exp = LevelManager.currentExp;
		maxExp = LevelManager.maxExp;
		gold = MoneyManager.currentGold;
		health = PlayerHealthManager.currentHealth;
		maxHealth = PlayerHealthManager.maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.G)) {
			level = LevelManager.currentLevel;
			exp = LevelManager.currentExp;
			maxExp = LevelManager.maxExp;
			gold = MoneyManager.currentGold;
			health = PlayerHealthManager.currentHealth;
			maxHealth = PlayerHealthManager.maxHealth;
				
			PlayerPrefs.SetInt("Level", level);
			PlayerPrefs.SetInt("currentExp", exp);
			PlayerPrefs.SetInt("maxExp", maxExp);
			PlayerPrefs.SetInt("gold", gold);
			PlayerPrefs.SetInt("gold", gold);
			PlayerPrefs.SetInt("health", health);
			PlayerPrefs.SetInt("maxHealth", maxHealth);
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			level = PlayerPrefs.GetInt("Level");
			exp = PlayerPrefs.GetInt("currentExp");
			maxExp = PlayerPrefs.GetInt("maxExp");
			gold = PlayerPrefs.GetInt("gold");
			health = PlayerPrefs.GetInt("health");
			maxHealth = PlayerPrefs.GetInt("maxHealth");
			LevelManager.setValues (level, exp, maxExp);
			MoneyManager.setMoney (gold);
			PlayerHealthManager.setHealth (health, maxHealth);
		}
	}
}
