using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour {

    public int questNumber;
    public string itemName;

    private QuestManager questManager;

	// Use this for initialization
	void Start () {
        questManager = FindObjectOfType<QuestManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            if(!questManager.questCompleted[questNumber] && questManager.quests[questNumber].gameObject.activeSelf)
            {
                questManager.itemCollected = itemName;
                //this.gameObject.SetActive(false);
            }
        }
    }
}
