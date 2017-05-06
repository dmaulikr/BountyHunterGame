using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPickup : MonoBehaviour {

    public int moneyValue;

    private MoneyManager moneyManager;

    private bool canGrab;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        moneyManager = FindObjectOfType<MoneyManager>();
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canGrab = true;

            if(Input.GetKeyDown(KeyCode.E))
            {
                audioSource.Play();
                moneyManager.addMoney(moneyValue);
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canGrab = false;
    }

    private void OnGUI()
    {
        if (canGrab)
        {
            GUI.Box(new Rect(Screen.width * 0.5f - (185f * 0.5f), 200, 185, 22), "Press E to grab money.");
        }
    }
}
