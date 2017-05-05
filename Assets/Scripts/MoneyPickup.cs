using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPickup : MonoBehaviour {

    public int moneyValue;

    private MoneyManager moneyManager;

	// Use this for initialization
	void Start () {
        moneyManager = FindObjectOfType<MoneyManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            moneyManager.addMoney(moneyValue);
            Destroy(this.gameObject);
        }
    }
}
