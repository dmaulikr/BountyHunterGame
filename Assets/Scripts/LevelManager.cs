using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public Text LvlText;
	public Text ExpText;
	public int currentLevel;
	public int maxExp;
	public int currentExp;

	// Use this for initialization
	void Start () {
		currentExp = 0;
		maxExp = 100;
		currentLevel = 1;
		LvlText.text = "Level: " + currentLevel;
		ExpText.text = "Exp: " + currentExp + "/" + maxExp;
	}
	
	// Update is called once per frame
	void Update () {
		if(currentExp >= maxExp)
		{
			addLevel ();
		}
		LvlText.text = "Level: " + currentLevel;
		ExpText.text = "Exp: " + currentExp + "/" + maxExp;
	}


	public void addLevel()
	{
		currentExp = 0;
		maxExp *= 2;
		currentLevel++;
	}

	public void addExp(int exp)
	{
		currentExp += exp;
	}
}
