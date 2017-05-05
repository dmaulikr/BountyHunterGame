using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

    public Text moneyText;
    public int currentGold;

	// Use this for initialization
	void Start () {
        currentGold = 0;
        moneyText.text = "Gold: " + currentGold;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addMoney(int gold)
    {
        currentGold += gold;
        moneyText.text = "Gold: " + currentGold;
    }
}
