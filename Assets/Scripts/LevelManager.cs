using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public Text LvlText;
	public Text ExpText;
	public static int currentLevel;
	public static int maxExp;
	public static int currentExp;

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


	public static void addLevel()
	{
		currentExp = 0;
		maxExp *= 2;
		currentLevel++;
	}

	public void addExp(int exp)
	{
		currentExp += exp;
	}

	public static void setValues(int level, int exp, int max){
		currentLevel = level;
		currentExp = exp;
		maxExp = max;
	}
}
